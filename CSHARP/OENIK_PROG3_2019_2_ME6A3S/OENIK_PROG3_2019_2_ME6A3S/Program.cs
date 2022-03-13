// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace OENIK_PROG3_2019_2_ME6A3S
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The program loads from here.
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is the main method of the program.
        /// </summary>
        /// <param name="args">arguments.</param>
        static void Main(string[] args)
        {
            UIDesigner design = new UIDesigner();
            design.MainMenu();
        }
    }
}
