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
    interface IPatientRepository
    {

    }
    interface IPatientService
    {

    }
    class Patient
    {

    }
    class PatientRepository
    {

    }

    class PatientService
    {

    }


    //2. Appointment Scheduling:
    interface IAppointmentRepository
    {

    }
    interface IAppointmentService
    {

    }
    class Appointment
    {

    }
    class AppointmentRepository
    {
        
    }
    class AppointmentService
    {

    }

    //3. Billing and Payment:
    interface IBillingRepository
    {

    }
    class IPaymentProcessor
    {

    }
    class Billing
    {

    }
    class Invoice
    {

    }
    class Payment
    {

    }
    class BillingRepository
    {

    }
    class PaymentProcessor
    {

    }


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
