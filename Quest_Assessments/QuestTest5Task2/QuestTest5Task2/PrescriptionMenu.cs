using System;
using System.Collections.Generic;
using QuestTest5Task2PrescriptionUI;

namespace QuestTest5Task2Menu
{
    public class PrescriptionMenu
    {
        public static void Menu()
        {
            PrescriptionUI ui = new PrescriptionUI();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nPrescription Management System");
                Console.WriteLine("1. Create Prescription");
                Console.WriteLine("2. Read Prescription");
                Console.WriteLine("3. Update Prescription");
                Console.WriteLine("4. Delete Prescription");
                Console.WriteLine("5. List All Prescriptions");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ui.CreatePrescription();
                        break;
                    case "2":
                        ui.ReadPrescription();
                        break;
                    case "3":
                        ui.UpdatePrescription();
                        break;
                    case "4":
                        ui.DeletePrescription();
                        break;
                    case "5":
                        ui.ListAllPrescriptions();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
