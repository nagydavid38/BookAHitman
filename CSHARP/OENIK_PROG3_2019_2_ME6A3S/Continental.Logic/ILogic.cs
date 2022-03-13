// <copyright file="ILogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Continental.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Continental.Data;
    using Continental.Repository;

    
    public interface ILogic
    {
        /// <summary>
        /// Sends the created Hitman entity to the corresponding repository method.
        /// </summary>
        /// <param name="hitman">The created entity.</param>
        void CreateHitman(Hitman hitman);

        /// <summary>
        /// Returns the contents of the Hitman table.
        /// </summary>
        /// <returns>The whole Hitman table.</returns>
        IQueryable<Hitman> ReadHitman();

        /// <summary>
        /// Sends a request to the corresponding repository to update a member of the table, identified by the id parameter.
        /// </summary>
        /// <param name="id">ID of the modifiable entity.</param>
        /// <param name="columnToUpdate">name of the attribute which value will be modified.</param>
        /// <param name="val">the value to modify the column.</param>
        void UpdateHitman(int id, string columnToUpdate, string val);

        /// <summary>
        /// Deletes a member of the table, identified by the id parameter.
        /// </summary>
        /// <param name="id">ID of the removable member.</param>
        void DeleteHitman(int id);

        /// <summary>
        /// This method sends the created Target entity to the corresponding repository method.
        /// </summary>
        /// <param name="target">The created entity.</param>
        void CreateTarget(Target target);

        /// <summary>
        /// Returns the contents of the Target table.
        /// </summary>
        /// <returns>The whole Target table.</returns>
        IQueryable<Target> ReadTarget();

        /// <summary>
        /// Sends a request to the corresponding repository to update a member of the table, identified by the id parameter.
        /// </summary>
        /// <param name="id">ID of the modifiable entity.</param>
        /// <param name="columnToUpdate">name of the attribute which value will be modified.</param>
        /// <param name="val">the value to modify the column.</param>
        void UpdateTarget(int id, string columnToUpdate, string val);

        /// <summary>
        /// Deletes a member of the table, identified by the id parameter.
        /// </summary>
        /// <param name="id">ID of the removable member.</param>
        void DeleteTarget(int id);

        /// <summary>
        /// This method sends the created Extra Wish entity to the corresponding repository method.
        /// </summary>
        /// <param name="wish">The created entity.</param>
        void CreateWish(ExtraWish wish);

        /// <summary>
        /// Returns the contents of the Extra Wish table.
        /// </summary>
        /// <returns>The whole Extra Wish table.</returns>
        IQueryable<ExtraWish> ReadWish();

        /// <summary>
        /// Sends a request to the corresponding repository to update a member of the table, identified by the id parameter.
        /// </summary>
        /// <param name="id">ID of the modifiable entity.</param>
        /// <param name="columnToUpdate">name of the attribute which value will be modified.</param>
        /// <param name="val">the value to modify the column.</param>
        void UpdateWish(int id, string columnToUpdate, string val);

        /// <summary>
        /// Deletes a member of the table, identified by the id parameter.
        /// </summary>
        /// <param name="id">ID of the removable member.</param>
        void DeleteWish(int id);

        /// <summary>
        /// This method sends the created Contract entity to the corresponding repository method.
        /// </summary>
        /// <param name="contract">The created entity.</param>
        void CreateContract(Contract contract);

        /// <summary>
        /// Returns the contents of the Contract table.
        /// </summary>
        /// <returns>The whole Contract table.</returns>
        IQueryable<Contract> ReadContract();

        /// <summary>
        /// Sends a request to the corresponding repository to update a member of the table, identified by the id parameter.
        /// </summary>
        /// <param name="id">ID of the modifiable entity.</param>
        /// <param name="columnToUpdate">name of the attribute which value will be modified.</param>
        /// <param name="val">the value to modify the column.</param>
        void UpdateContract(int id, string columnToUpdate, string val);

        /// <summary>
        /// Deletes a member of the table, identified by the id parameter.
        /// </summary>
        /// <param name="id">ID of the removable member.</param>
        void DeleteContract(int id);


        /// <summary>
        /// Returns all contracts.
        /// </summary>
        /// <returns>List.</returns>
        List<string> AllContracts();

        /// <summary>
        /// Returns the most expensive hitmen.
        /// </summary>
        /// <returns>List.</returns>
        List<string> MostExpensive();

        /// <summary>
        /// Return the contract name The Italian Job
        /// </summary>
        /// <returns>string.</returns>
        string TheItalianJob();

        /// <summary>
        /// Runs the java web call.
        /// </summary>
        void JavaWeb();
        
    }
}
