/*Domain-Specific Use Case

1. Patient Registration and Management:
   - Requirement: 
    The clinic needs to store and manage patient information, 
    including name, 
    contact details, 
    medical history, and 
    current medications.
   - Implementation:
     - Classes: 
        `Patient`, `PatientRepository`, and `PatientService`.
     - Interfaces: 
        `IPatientRepository`, `IPatientService`.

2. Appointment Scheduling:
   - Requirement: 
    Patients should be able 
        to schedule, reschedule, and cancel appointments. 
        The system should ensure 
        that doctors are not double-booked and 
        should also send reminders.
   - Implementation:
     - Classes: 
        `Appointment`, `AppointmentRepository`, `AppointmentService`.
     - Interfaces: 
        `IAppointmentRepository`, `IAppointmentService`.

3. Billing and Payment:
   - Requirement: 
        The clinic needs to generate bills 
        for services provided to patients. 
        It should handle different payment methods, 
        including credit cards, insurance, and cash.
   - Implementation:
     - Classes: 
        `Billing`, `Invoice`, `Payment`, 
        `BillingRepository`, `PaymentProcessor`.
     - Interfaces: 
        `IBillingRepository`, 
        `IPaymentProcessor`.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem_using_SOLID_Principles
{
    //1. Patient Registration and Management:
    public interface IPatientRepository
    {
        void AddPatient(Patient patient);
        Patient GetPatient(int id);
        IEnumerable<Patient> GetAllPatients();
    }
    public interface IPatientService
    {

    }
    public class Patient
    {
        public int PatientID { get; private set; }
        public string Name { get; set; }
        public string MedicalHistory { get; set; }

        public Patient(int patientID, string name, string medicalHistory)
        {
            PatientID = patientID;
            Name = name;
            MedicalHistory = medicalHistory;
        }

        public Patient()
        {
        }
    }
    public class PatientRepository : IPatientRepository
    {
        private readonly List<Patient> _patients = new List<Patient>();

        public void AddPatient(Patient patient)
        {
            _patients.Add(patient);
        }

        public Patient GetPatient(int id)
        {
            return _patients.FirstOrDefault(p => p.PatientID == id);
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _patients;
        }
    }

    public class PatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public void RegisterPatient(int patientID, string name, string medicalHistory)
        {
            var patient = new Patient(patientID, name, medicalHistory);
            _patientRepository.AddPatient(patient);
        }

        public Patient GetPatient(int patientID)
        {
            return _patientRepository.GetPatient(patientID);
        }
    }


    //2. Appointment Scheduling:
    public interface IAppointmentRepository
    {
        void ScheduleAppointment(Appointment appointment);
        void CancelAppointment(int appointmentID);
        IEnumerable<Appointment> GetAppointmentsByPatient(int patientID);
    }
    public interface IAppointmentService
    {

    }
    public class Appointment
    {
        public int AppointmentID { get; private set; }
        public int PatientID { get; private set; }
        public DateTime Date { get; set; }
        public string Doctor { get; set; }

        public Appointment(int appointmentID, int patientID, DateTime date, string doctor)
        {
            AppointmentID = appointmentID;
            PatientID = patientID;
            Date = date;
            Doctor = doctor;
        }
    }
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();

        public void ScheduleAppointment(Appointment appointment)
        {
            _appointments.Add(appointment);
        }

        public void CancelAppointment(int appointmentID)
        {
            var appointment = _appointments.FirstOrDefault(a => a.AppointmentID == appointmentID);
            if (appointment != null)
            {
                _appointments.Remove(appointment);
            }
        }

        public IEnumerable<Appointment> GetAppointmentsByPatient(int patientID)
        {
            return _appointments.Where(a => a.PatientID == patientID);
        }
    }
    public class AppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public void ScheduleAppointment(int appointmentID, int patientID, DateTime date, string doctor)
        {
            var appointment = new Appointment(appointmentID, patientID, date, doctor);
            _appointmentRepository.ScheduleAppointment(appointment);
        }

        public void CancelAppointment(int appointmentID)
        {
            _appointmentRepository.CancelAppointment(appointmentID);
        }
    }

    //3. Billing and Payment:
    public interface IBillingRepository
    {
        void GenerateInvoice(Invoice invoice);
        Invoice GetInvoice(int invoiceID);
    }
    public interface IPaymentProcessor
    {
        void ProcessPayment(Payment payment);
    }
    public class BillingService
    {
        private readonly IBillingRepository _billingRepository;
        private readonly IPaymentProcessor _paymentProcessor;

        public BillingService(IBillingRepository billingRepository, IPaymentProcessor paymentProcessor)
        {
            _billingRepository = billingRepository;
            _paymentProcessor = paymentProcessor;
        }

        public void GenerateInvoice(int invoiceID, int patientID, decimal amount)
        {
            var invoice = new Invoice(invoiceID, patientID, amount);
            _billingRepository.GenerateInvoice(invoice);
        }

        public void ProcessPayment(int paymentID, int invoiceID, decimal amount, string method)
        {
            var payment = new Payment(paymentID, invoiceID, amount, method);
            _paymentProcessor.ProcessPayment(payment);
        }
    }
    public class Invoice
    {
        public int InvoiceID { get; private set; }
        public int PatientID { get; private set; }
        public decimal Amount { get; private set; }

        public Invoice(int invoiceID, int patientID, decimal amount)
        {
            InvoiceID = invoiceID;
            PatientID = patientID;
            Amount = amount;
        }
    }
    public class Payment
    {
        public int PaymentID { get; private set; }
        public int InvoiceID { get; private set; }
        public decimal Amount { get; private set; }
        public string Method { get; private set; }  // e.g., Credit Card, Insurance

        public Payment(int paymentID, int invoiceID, decimal amount, string method)
        {
            PaymentID = paymentID;
            InvoiceID = invoiceID;
            Amount = amount;
            Method = method;
        }
    }
    public class BillingRepository : IBillingRepository 
    {
        private readonly List<Invoice> _invoices = new List<Invoice>();

        public void GenerateInvoice(Invoice invoice)
        {
            _invoices.Add(invoice);
        }

        public Invoice GetInvoice(int invoiceID)
        {
            return _invoices.FirstOrDefault(i => i.InvoiceID == invoiceID);
        }
    }
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Payment payment)
        {
            // Process credit card payment logic
        }
    }
    public class InsuranceProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Payment payment)
        {
            // Process insurance payment logic
        }
    }
    public class DoctorService
    {
        private readonly IPatientRepository _patientRepository;

        // Constructor to inject the PatientRepository
        public DoctorService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        // Method to get a patient by ID
        public Patient GetPatientById(int id)
        {
            return _patientRepository.GetPatient(id);
        }

        //// Method to add a new patient
        //public void AddNewPatient(int patientID, string name, string medicalHistory)
        //{
        //    var patient = new Patient(patientID, name, medicalHistory);
        //    _patientRepository.AddPatient(patient);
        //}

        //// Method to get all patients
        //public IEnumerable<Patient> GetAllPatients()
        //{
        //    return _patientRepository.GetAllPatients();
        //}

        // Method to review a patient's medical history
        public string ReviewPatientHistory(int patientID)
        {
            var patient = _patientRepository.GetPatient(patientID);
            if (patient != null)
            {
                return patient.MedicalHistory;
            }
            else
            {
                return "Patient not found.";
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of using the full Clinic Management System
            var patientRepository = new PatientRepository();
            var appointmentRepository = new AppointmentRepository();
            var billingRepository = new BillingRepository();
            var paymentProcessor = new CreditCardProcessor();

            var patientService = new PatientService(patientRepository);
            var appointmentService = new AppointmentService(appointmentRepository);
            var billingService = new BillingService(billingRepository, paymentProcessor);
            var doctorService = new DoctorService(patientRepository);

            // Register a patient
            patientService.RegisterPatient(1, "Jane Doe", "Hypertension, Allergic to Penicillin");

            // Schedule an appointment
            appointmentService.ScheduleAppointment(1, 1, DateTime.Now.AddDays(2), "Dr. Johnson");

            // Generate an invoice and process payment
            billingService.GenerateInvoice(1, 1, 150.00m);
            billingService.ProcessPayment(1, 1, 150.00m, "Credit Card");

            // Doctor reviews the patient's medical history
            doctorService.ReviewPatientHistory(1);
        }
    }
}
