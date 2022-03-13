// <copyright file="UIDesigner.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace OENIK_PROG3_2019_2_ME6A3S
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Continental.Data;
    using Continental.Logic;

    /// <summary>
    /// This is the class which handles the display, and base functions of the
    /// menu.
    /// </summary>
    class UIDesigner
    {
        private readonly BusinessLogic logic;

        /// <summary>
        /// Initializes a new instance of the <see cref="UIDesigner"/> class.
        /// </summary>
        public UIDesigner()
        {
            this.logic = new BusinessLogic();
        }

        /// <summary>
        /// This method creates the menu.
        /// </summary>
        public void MainMenu()
        {
            string input = string.Empty;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.) Hitman CRUD methods");
                Console.WriteLine("2.) Target CRUD methods");
                Console.WriteLine("3.) Extra Wish CRUD methods");
                Console.WriteLine("4.) Contract CRUD methods");
                Console.WriteLine("6.) Other listings");
                Console.WriteLine("q ) Quit");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    this.HitmanMenu();
                }
                else if (input == "2")
                {
                    Console.Clear();
                    this.TargetMenu();
                }
                else if (input == "3")
                {
                    Console.Clear();
                    this.ExtraWishMenu();
                }
                else if (input == "4")
                {
                    Console.Clear();
                    this.ContractMenu();
                }
                else if (input == "6")
                {
                    Console.Clear();
                    this.OtherMenu();
                }
                else
                {
                    if (input == "q")
                    {
                        Console.WriteLine("You will qiut...");
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
            }
            while (input != "q");
        }

        private void OtherMenu()
        {
            string input = string.Empty;
            do
            {
                Console.WriteLine("1.) All contracts");
                Console.WriteLine("2.) Most expensive hitmen");
                Console.WriteLine("3.) The Italian Job");
                Console.WriteLine("4.) Java web");
                Console.WriteLine("[q] Quit");
                input = Console.ReadLine();

                if (input == "1")
                {
                    this.AllContracts();
                    this.Done(string.Empty);
                }
                else if (input == "2")
                {
                    this.MostExpensive();
                    this.Done(string.Empty);
                }
                else if (input == "3")
                {
                    this.TheItalianJob();
                    this.Done(string.Empty);
                }
                else if (input == "4")
                {
                    this.JavaWeb();
                    this.Done(string.Empty);
                }
                else
                {
                    if (input == "q")
                    {
                        this.Done("You will quit...");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
            }
            while (input != "q");
        }

        private void JavaWeb()
        {
            Console.WriteLine("Starting Java");
            this.logic.JavaWeb();
        }

        private void AllContracts()
        {
            foreach (var item in this.logic.AllContracts())
            {
                Console.WriteLine(item);
            }
        }

        private void MostExpensive()
        {
            foreach (var item in this.logic.MostExpensive())
            {
                Console.WriteLine(item);
            }
        }

        private void TheItalianJob()
        {
            Console.WriteLine(this.logic.TheItalianJob());
        }

        private void TargetMenu()
        {
            string input = string.Empty;
            do
            {
                Console.WriteLine("1.  Create Target");
                Console.WriteLine("2.  Read Target");
                Console.WriteLine("3.  Update Target");
                Console.WriteLine("4.  Delete Target");
                Console.WriteLine("[q] Quit");
                input = Console.ReadLine();

                if (input == "1")
                {
                    this.CreateTarget();
                    this.Done("Target created");
                }
                else if (input == "2")
                {
                    this.ReadTarget();
                    this.Done(string.Empty);
                }
                else if (input == "3")
                {
                    this.UpdateTarget();
                    this.Done("Target updated");
                }
                else if (input == "4")
                {
                    this.DeleteTarget();
                    this.Done("Target deleted");
                }
                else
                {
                    if (input == "q")
                    {
                        this.Done("You will quit...");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
            }
            while (input != "q");
        }

        private void HitmanMenu()
        {
            string input = string.Empty;
            do
            {
                Console.WriteLine("1.  Create Hitman");
                Console.WriteLine("2.  Read Hitman");
                Console.WriteLine("3.  Update Hitman");
                Console.WriteLine("4.  Delete Hitman");
                Console.WriteLine("[q] Quit");
                input = Console.ReadLine();

                if (input == "1")
                {
                    this.CreateHitman();
                    this.Done("Hitman created");
                }
                else if (input == "2")
                {
                    this.ReadHitman();
                    this.Done(string.Empty);
                }
                else if (input == "3")
                {
                    this.UpdateHitman();
                    this.Done("Hitman updated");
                }
                else if (input == "4")
                {
                    this.DeleteHitman();
                    this.Done("Hitman deleted");
                }
                else
                {
                    if (input == "q")
                    {
                        this.Done("You will quit...");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
            }
            while (input != "q");
        }

        private void ContractMenu()
        {
            string input = string.Empty;
            do
            {
                Console.WriteLine("1.  Create Contract");
                Console.WriteLine("2.  Read Contracts");
                Console.WriteLine("3.  Update Contracts");
                Console.WriteLine("4.  Delete Contract");
                Console.WriteLine("[q] Quit");
                input = Console.ReadLine();

                if (input == "1")
                {
                    this.CreateContract();
                    this.Done("Contract created");
                }
                else if (input == "2")
                {
                    this.ReadContract();
                    this.Done(string.Empty);
                }
                else if (input == "3")
                {
                    this.UpdateContract();
                    this.Done("Contract updated");
                }
                else if (input == "4")
                {
                    this.DeleteContract();
                    this.Done("Contract deleted");
                }
                else
                {
                    if (input == "q")
                    {
                        this.Done("You will quit...");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
            }
            while (input != "q");
        }

        private void ExtraWishMenu()
        {
            string input = string.Empty;
            do
            {
                Console.WriteLine("1.  Create Extra Wish");
                Console.WriteLine("2.  Read Extra Wishes");
                Console.WriteLine("3.  Update Extra Wishes");
                Console.WriteLine("4.  Delete Extra Wish");
                Console.WriteLine("[q] Quit");
                input = Console.ReadLine();

                if (input == "1")
                {
                    this.CreateExtraWish();
                    this.Done("Extra Wish created");
                }
                else if (input == "2")
                {
                    this.ReadExtraWish();
                    this.Done(string.Empty);
                }
                else if (input == "3")
                {
                    this.UpdateWish();
                    this.Done("Wish updated");
                }
                else if (input == "4")
                {
                    this.DeleteWish();
                    this.Done("Wish deleted");
                }
                else
                {
                    if (input == "q")
                    {
                        this.Done("You will quit...");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
            }
            while (input != "q");
        }

        private void Done(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press a button to continue");
            Console.ReadKey();
            Console.Clear();
        }

        private void DeleteHitman()
        {
            Console.WriteLine("Enter ID: ");
            this.logic.DeleteHitman(int.Parse(Console.ReadLine()));
        }

        private void DeleteTarget()
        {
            Console.WriteLine("Enter ID: ");
            this.logic.DeleteTarget(int.Parse(Console.ReadLine()));
        }

        private void DeleteContract()
        {
            Console.WriteLine("Enter ID: ");
            this.logic.DeleteContract(int.Parse(Console.ReadLine()));
        }

        private void DeleteWish()
        {
            Console.WriteLine("Enter ID: ");
            this.logic.DeleteWish(int.Parse(Console.ReadLine()));
        }

        private void UpdateHitman()
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Which attribute would you like to upgrade?");
            string attr = Console.ReadLine();
            Console.WriteLine("With what value?");
            string val = Console.ReadLine();
            this.logic.UpdateHitman(id, attr, val);
        }

        private void UpdateTarget()
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Which attribute would you like to upgrade?");
            string attr = Console.ReadLine();
            Console.WriteLine("With what value?");
            string val = Console.ReadLine();
            this.logic.UpdateTarget(id, attr, val);
        }

        private void UpdateWish()
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Which attribute would you like to upgrade?");
            string attr = Console.ReadLine();
            Console.WriteLine("With what value?");
            string val = Console.ReadLine();
            this.logic.UpdateWish(id, attr, val);
        }

        private void UpdateContract()
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Which attribute would you like to upgrade?");
            string attr = Console.ReadLine();
            Console.WriteLine("With what value?");
            string val = Console.ReadLine();
            this.logic.UpdateContract(id, attr, val);
        }

        private void ReadHitman()
        {
            foreach (Hitman item in this.logic.ReadHitman())
            {
                Console.WriteLine(item.Hitman_ID + " - " + item.Hitman_Name + " - " + item.Style + " - " + item.Basic_Price);
            }
        }

        private void ReadTarget()
        {
            foreach (Target item in this.logic.ReadTarget())
            {
                Console.WriteLine(item.Target_ID + " - " + item.Target_Name + " - " + item.Target_Location + " - " + item.Risk);
            }
        }

        private void ReadContract()
        {
            foreach (Contract item in this.logic.ReadContract())
            {
                Console.WriteLine(item.Contract_ID + " - " + item.Contract_Name + " - " + item.Hitman_ID + " - " + item.Target_ID + " - " + item.Extra_Wish_ID);
            }
        }

        private void ReadExtraWish()
        {
            foreach (ExtraWish item in this.logic.ReadWish())
            {
                Console.WriteLine(item.Wish_ID + " - " + item.Wish + " - " + item.Extra_Price);
            }
        }

        private void CreateHitman()
        {
            Hitman hitman = new Hitman();
            Console.Write("ID: ");
            hitman.Hitman_ID = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            hitman.Hitman_Name = Console.ReadLine();
            Console.Write("Style: ");
            hitman.Style = Console.ReadLine();
            Console.Write("Price: ");
            hitman.Basic_Price = int.Parse(Console.ReadLine());
            this.logic.CreateHitman(hitman);
        }

        private void CreateTarget()
        {
            Target target = new Target();
            Console.Write("ID: ");
            target.Target_ID = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            target.Target_Name = Console.ReadLine();
            Console.Write("Location: ");
            target.Target_Location = Console.ReadLine();
            Console.Write("Risk: ");
            target.Risk = int.Parse(Console.ReadLine());
            this.logic.CreateTarget(target);
        }

        private void CreateContract()
        {
            Contract contract = new Contract();
            Console.Write("ID: ");
            contract.Contract_ID = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            contract.Contract_Name = Console.ReadLine();
            Console.Write("Hitman ID: ");
            contract.Hitman_ID = int.Parse(Console.ReadLine());
            Console.Write("Target ID: ");
            contract.Target_ID = int.Parse(Console.ReadLine());
            Console.Write("Extra Wish ID: ");
            contract.Extra_Wish_ID = int.Parse(Console.ReadLine());
            this.logic.CreateContract(contract);
        }

        private void CreateExtraWish()
        {
            ExtraWish ew = new ExtraWish();
            Console.Write("ID: ");
            ew.Wish_ID = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            ew.Wish = Console.ReadLine();
            Console.Write("Price: ");
            ew.Extra_Price = int.Parse(Console.ReadLine());
            this.logic.CreateWish(ew);
        }
    }
}
