// <copyright file="BusinessLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>


namespace Continental.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using Continental.Data;
    using Continental.Repository;

    /// <summary>
    /// This class implements the ILogic interface and does the
    /// logical tasks before data send forward to the Repository.
    /// </summary>
    public class BusinessLogic : ILogic
   {
        private readonly IDynamicRepo<Hitman> hitmanrepo;
        private readonly IDynamicRepo<Target> targetrepo;
        private readonly IDynamicRepo<ExtraWish> wishrepo;
        private readonly IDynamicRepo<Contract> contractrepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogic"/> class.
        /// Creates instances of the database repositories.
        /// </summary>
        public BusinessLogic()
        {
            this.hitmanrepo = new DynamicRepo<Hitman>();
            this.targetrepo = new DynamicRepo<Target>();
            this.wishrepo = new DynamicRepo<ExtraWish>();
            this.contractrepo = new DynamicRepo<Contract>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLogic"/> class.
        /// Creates instance of the mocked repositories.
        /// </summary>
        public BusinessLogic(IDynamicRepo<Hitman> hitmanrepo, IDynamicRepo<Target> targetrepo, IDynamicRepo<ExtraWish> wishrepo, IDynamicRepo<Contract> contractrepo)
        {
            this.hitmanrepo = hitmanrepo;
            this.targetrepo = targetrepo;
            this.wishrepo = wishrepo;
            this.contractrepo = contractrepo;
        }

        /// <inheritdoc/>
        public List<string> AllContracts()
        {
            var p = from hitman in this.hitmanrepo.GetAll().ToList()
                    join contract in this.contractrepo.GetAll().ToList() on hitman.Hitman_ID equals contract.Hitman_ID
                    join target in this.targetrepo.GetAll().ToList() on contract.Target_ID equals target.Target_ID
                    select contract.Contract_Name + " - " + hitman.Hitman_Name + " - " + target.Target_Name;
            return p.ToList();
        }

        /// <inheritdoc/>
        public void CreateContract(Contract contract) => this.contractrepo.Create(contract);

        /// <inheritdoc/>
        public void CreateHitman(Hitman hitman) => this.hitmanrepo.Create(hitman);

        /// <inheritdoc/>
        public void CreateTarget(Target target) => this.targetrepo.Create(target);

        /// <inheritdoc/>
        public void CreateWish(ExtraWish wish) => this.wishrepo.Create(wish);

        /// <inheritdoc/>
        public void DeleteContract(int id) => this.contractrepo.Delete(id);

        /// <inheritdoc/>
        public void DeleteHitman(int id) => this.hitmanrepo.Delete(id);

        /// <inheritdoc/>
        public void DeleteTarget(int id) => this.targetrepo.Delete(id);

        /// <inheritdoc/>
        public void DeleteWish(int id) => this.wishrepo.Delete(id);


        /// <inheritdoc/>
        public List<string> MostExpensive()
        {
            var p = from hitman in this.hitmanrepo.GetAll().ToList()
                    where hitman.Basic_Price >= 7000
                    select hitman.Hitman_ID + " - " + hitman.Hitman_Name;
            return p.ToList();
        }

        /// <inheritdoc/>
        public IQueryable<Contract> ReadContract() => this.contractrepo.GetAll();

        /// <inheritdoc/>
        public IQueryable<Hitman> ReadHitman() => this.hitmanrepo.GetAll();

        /// <inheritdoc/>
        public IQueryable<Target> ReadTarget() => this.targetrepo.GetAll();

        /// <inheritdoc/>
        public IQueryable<ExtraWish> ReadWish() => this.wishrepo.GetAll();

        /// <inheritdoc/>
        public string TheItalianJob()
        {
            var q = from hitman in this.hitmanrepo.GetAll().ToList()
                    join contract in this.contractrepo.GetAll().ToList() on hitman.Hitman_ID equals contract.Hitman_ID
                    join target in this.targetrepo.GetAll().ToList() on contract.Target_ID equals target.Target_ID
                    where target.Target_Location == "Rome"
                    select contract.Contract_Name + " - " + target.Target_Name + " - " + hitman.Hitman_Name;
            return q.FirstOrDefault();
        }

        /// <inheritdoc/>
        public void UpdateContract(int id, string columnToUpdate, string val) => this.contractrepo.Update(id, columnToUpdate, val);

        /// <inheritdoc/>
        public void UpdateHitman(int id, string columnToUpdate, string val) => this.hitmanrepo.Update(id, columnToUpdate, val);

        /// <inheritdoc/>
        public void UpdateTarget(int id, string columnToUpdate, string val) => this.targetrepo.Update(id, columnToUpdate, val);

        /// <inheritdoc/>
        public void UpdateWish(int id, string columnToUpdate, string val) => this.wishrepo.Update(id, columnToUpdate, val);
    }
}
