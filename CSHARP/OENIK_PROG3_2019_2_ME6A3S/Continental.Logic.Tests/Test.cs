// <copyright file="Test.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Continental.Logic.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Continental.Data;
    using Continental.Repository;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Test
    {
        private Mock<IDynamicRepo<Hitman>> MoqHitman;
        private Mock<IDynamicRepo<Target>> MoqTarget;
        private Mock<IDynamicRepo<Contract>> MoqContract;
        private Mock<IDynamicRepo<ExtraWish>> MoqWish;
        private BusinessLogic testLogic;

        /// <summary>
        /// Setting up the mock repositories and creates an
        /// instance of BusinessLogic what will be tested
        /// </summary>
        [SetUp]
        public void SetupTests()
        {
            this.MoqHitman = new Mock<IDynamicRepo<Hitman>>();
            this.MoqTarget = new Mock<IDynamicRepo<Target>>();
            this.MoqContract = new Mock<IDynamicRepo<Contract>>();
            this.MoqWish = new Mock<IDynamicRepo<ExtraWish>>();
            this.testLogic = new BusinessLogic(this.MoqHitman.Object, this.MoqTarget.Object, this.MoqWish.Object, this.MoqContract.Object);
        }

        /// <summary>
        /// Testing CreateHitman method.
        /// </summary>
        [Test]
        public void TestCreateHitman()
        {
            Hitman h1 = new Hitman();
            this.MoqHitman.Setup(x => x.Create(h1)).Verifiable();
            this.testLogic.CreateHitman(h1);
            this.MoqHitman.Verify(x => x.Create(h1), Times.Once);
        }

        /// <summary>
        /// Testing DeleteHitman method.
        /// </summary>
        [Test]
        public void TestDeleteHitman()
        {
            Hitman h1 = new Hitman();
            this.MoqHitman.Setup(x => x.Delete((int)h1.Hitman_ID)).Verifiable();
            this.testLogic.DeleteHitman((int)h1.Hitman_ID);
            this.MoqHitman.Verify(x => x.Delete((int)h1.Hitman_ID), Times.Once);
        }

        /// <summary>
        /// Testing GetAllHitmen method.
        /// </summary>
        [Test]
        public void TestGetAllHitmen()
        {
            Hitman h1 = new Hitman();
            Hitman h2 = new Hitman();
            Hitman h3 = new Hitman();
            List<Hitman> hlist = new List<Hitman>() { h1,h2,h3 };
            this.MoqHitman.Setup(x => x.GetAll()).Returns(hlist.AsQueryable());
            var vmi=this.testLogic.ReadHitman();
            CollectionAssert.AreEqual(hlist, vmi);
        }

        /// <summary>
        /// Testing UpdateHitman method.
        /// </summary>
        [Test]
        public void TestUpdateHitmanName()
        {
            Hitman h1 = new Hitman() { Hitman_ID = 1, Hitman_Name = "Jon", Style = "Martial Arts", Basic_Price = 3000 };
            this.MoqHitman.Setup(x => x.Update((int)h1.Hitman_ID, "Hitman_Name" ,h1.Hitman_Name));
            this.testLogic.UpdateHitman((int)h1.Hitman_ID, "Hitman_Name" ,"vmi");
            this.MoqHitman.Verify(x => x.Update(It.IsAny<int>(), "Hitman_Name" ,"vmi"), Times.Once);
        }

        /// <summary>
        /// Testing UpdateHitman method.
        /// </summary>
        [Test]
        public void TestUpdateHitmanBasicPrice()
        {
            Hitman h1 = new Hitman() { Hitman_ID = 1, Hitman_Name = "Jon", Style = "Martial Arts", Basic_Price = 3000 };
            this.MoqHitman.Setup(x => x.Update((int)h1.Hitman_ID, "Basic_Price" ,h1.Basic_Price.ToString())).Verifiable();
            this.testLogic.UpdateHitman((int)h1.Hitman_ID, "Basic_Price", 4500.ToString());
            this.MoqHitman.Verify(x => x.Update(It.IsAny<int>(), "Basic_Price", 4500.ToString()));
        }

        /// <summary>
        /// Testing CreateTarget method.
        /// </summary>
        [Test]
        public void TestCreateTarget()
        {
            Target t1 = new Target();
            this.MoqTarget.Setup(x => x.Create(t1)).Verifiable();
            this.testLogic.CreateTarget(t1);
            this.MoqTarget.Verify(x => x.Create(t1), Times.Once());
        }

        /// <summary>
        /// Testing DeleteTarget method.
        /// </summary>
        [Test]
        public void TestDeleteTarget()
        {
            Target t1 = new Target();
            this.MoqTarget.Setup(x => x.Delete((int)t1.Target_ID)).Verifiable();
            this.testLogic.DeleteTarget((int)t1.Target_ID);
            this.MoqTarget.Verify(x => x.Delete((int)t1.Target_ID), Times.Once);
        }

        /// <summary>
        /// Testing GetAllTargets method.
        /// </summary>
        [Test]
        public void TestGetAllTargets()
        {
            Target t1 = new Target();
            Target t2 = new Target();
            Target t3 = new Target();
            List<Target> tlist = new List<Target>() { t1, t2, t3 };
            this.MoqTarget.Setup(x => x.GetAll()).Returns(tlist.AsQueryable());
            var teszt=this.testLogic.ReadTarget();
            CollectionAssert.AreEqual(tlist, teszt);
        }

        /// <summary>
        /// Testing UpdateTarget method.
        /// </summary>
        [Test]
        public void TestUpdateTargetLocation()
        {
            Target t1 = new Target() { Target_ID = 1, Target_Name = "Laci", Target_Location = "Rio" };
            this.MoqTarget.Setup(x => x.Update((int)t1.Target_ID, "Target_Location", t1.Target_Location));
            this.testLogic.UpdateTarget((int)t1.Target_ID, "Target_Location",  "BP");
            this.MoqTarget.Verify(x => x.Update(It.IsAny<int>(), "Target_Location", "BP"), Times.Once);
        }

        /// <summary>
        /// Testing UpdateTargetName method.
        /// </summary>
        [Test]
        public void TestUpdateTargetName()
        {
            Target t1 = new Target() { Target_ID = 1, Target_Name = "Laci", Target_Location = "Rio" };
            this.MoqTarget.Setup(x => x.Update((int)t1.Target_ID, "Target_Name", t1.Target_Name));
            this.testLogic.UpdateTarget((int)t1.Target_ID, "Target_Name", "Zsófi");
            this.MoqTarget.Verify(x => x.Update(It.IsAny<int>(), "Target_Name", "Zsófi"));
        }

        /// <summary>
        /// Testing CreateWish method.
        /// </summary>
        [Test]
        public void TestCreateWish()
        {
            ExtraWish w1 = new ExtraWish();
            this.MoqWish.Setup(x => x.Create(w1)).Verifiable();
            this.testLogic.CreateWish(w1);
            this.MoqWish.Verify(x => x.Create(It.IsAny<ExtraWish>()));
        }

        /// <summary>
        /// Testing DeleteWish method.
        /// </summary>
        [Test]
        public void TestDeleteWish()
        {
            ExtraWish w1 = new ExtraWish();
            this.MoqWish.Setup(x => x.Delete((int)w1.Wish_ID)).Verifiable();
            this.testLogic.DeleteWish((int)w1.Wish_ID);
            this.MoqWish.Verify(x => x.Delete((int)w1.Wish_ID));
        }

        /// <summary>
        /// Testing GetAllWishes method.
        /// </summary>
        [Test]
        public void TestGetAllWishes()
        {
            ExtraWish w1 = new ExtraWish();
            ExtraWish w2 = new ExtraWish();
            ExtraWish w3 = new ExtraWish();
            List<ExtraWish> wlist = new List<ExtraWish>() { w1, w2, w3 };
            this.MoqWish.Setup(x => x.GetAll()).Returns(wlist.AsQueryable());
            var teszt = this.testLogic.ReadWish();
            CollectionAssert.AreEqual(wlist, teszt);
        }

        /// <summary>
        /// Testing UpdateWish method.
        /// </summary>
        [Test]
        public void TestUpdateWishName()
        {
            ExtraWish w1 = new ExtraWish() { Wish_ID = 1, Wish = "set up as accident", Extra_Price = 1200 };
            this.MoqWish.Setup(x => x.Update((int)w1.Wish_ID, "Wish", w1.Wish));
            this.testLogic.UpdateWish((int)w1.Wish_ID, "Wish", "set up");
            this.MoqWish.Verify(x => x.Update(It.IsAny<int>(), "Wish", "set up"), Times.Once);
        }

        /// <summary>
        /// Testing UpdateWish method.
        /// </summary>
        [Test]
        public void TestUpdateWishPrice()
        {
            ExtraWish w1 = new ExtraWish() { Wish_ID = 1, Wish = "set up as accident", Extra_Price = 1200 };
            this.MoqWish.Setup(x => x.Update((int)w1.Wish_ID, "Extra_Price", w1.Extra_Price.ToString())).Verifiable();
            this.testLogic.UpdateWish((int)w1.Wish_ID, "Extra_Price", 2500.ToString());
            this.MoqWish.Verify(x => x.Update(It.IsAny<int>(), "Extra_Price", 2500.ToString()));
        }

        /// <summary>
        /// Testing CreateContract method.
        /// </summary>
        [Test]
        public void TestCreateContract()
        {
            Contract c1 = new Contract();
            this.MoqContract.Setup(x => x.Create(c1)).Verifiable();
            this.testLogic.CreateContract(c1);
            this.MoqContract.Verify(x => x.Create(It.IsAny<Contract>()));
        }

        /// <summary>
        /// Testing CreateContract method.
        /// </summary>
        [Test]
        public void TestCreateContract2()
        {
            Contract c1 = new Contract();
            this.MoqContract.Setup(x => x.Create(c1)).Verifiable();
            this.testLogic.CreateContract(c1);
            this.MoqContract.Verify(x => x.Create(c1));
        }

        /// <summary>
        /// Testing DeleteContract method.
        /// </summary>
        [Test]
        public void TestDeleteContract()
        {
            Contract c1 = new Contract();
            this.MoqContract.Setup(x => x.Delete((int)c1.Contract_ID)).Verifiable();
            this.testLogic.DeleteContract((int)c1.Contract_ID);
            this.MoqContract.Verify(x => x.Delete((int)c1.Contract_ID));
        }

        /// <summary>
        /// Testing GetAllContracts method.
        /// </summary>
        [Test]
        public void TestGetAllContracts()
        {
            Contract c1 = new Contract();
            Contract c2 = new Contract();
            Contract c3 = new Contract();
            Contract c4 = new Contract();
            List<Contract> clist = new List<Contract>() { c1, c2, c3, c4 };
            this.MoqContract.Setup(x => x.GetAll()).Returns(clist.AsQueryable());
            var teszt=this.testLogic.ReadContract();
            CollectionAssert.AreEqual(clist, teszt);
        }

        /// <summary>
        /// Testing TheItalianJob method.
        /// </summary>
        [Test]
        public void TestTheItalianJob()
        {
            Hitman h1 = new Hitman() { Hitman_ID = 1, Hitman_Name = "Józsi", Style = "Martial Arts", Basic_Price = 1000 };
            Target t1 = new Target() { Target_ID = 1, Target_Name = "The Pope", Target_Location = "Rome", Risk = 0 };
            Contract c1 = new Contract() { Contract_ID = 1, Contract_Name = "The Pope Contract", Target_ID = 1, Hitman_ID = 1 };
            Contract c2 = new Contract() { Contract_ID = 2, Contract_Name = "The Padasdantract", Target_ID = 4, Hitman_ID = 1 };
            Contract c3 = new Contract() { Contract_ID = 3, Contract_Name = "Tasdat", Target_ID = 1, Hitman_ID = 5 };

            List<Hitman> hlist = new List<Hitman>() { h1 };
            List<Target> tlist = new List<Target>() { t1 };
            List<Contract> clist = new List<Contract>() { c1, c2, c3 };

            this.MoqHitman.Setup(x => x.GetAll()).Returns(hlist.AsQueryable());
            this.MoqTarget.Setup(x => x.GetAll()).Returns(tlist.AsQueryable());
            this.MoqContract.Setup(x => x.GetAll()).Returns(clist.AsQueryable());

            string teszt = this.testLogic.TheItalianJob();

            string expected = c1.Contract_Name + " - " + t1.Target_Name + " - " + h1.Hitman_Name;

            Assert.That(teszt, Is.EqualTo(expected));
        }

        /// <summary>
        /// Testing TheMostExpensive method.
        /// </summary>
        [Test]
        public void TestMostExpensive()
        {
            Hitman h1 = new Hitman() { Hitman_ID = 1, Hitman_Name = "Józsi", Style = "Martial Arts", Basic_Price = 7000 };
            Hitman h2 = new Hitman() { Hitman_ID = 2, Hitman_Name = "Jasper", Style = "Martial Arts", Basic_Price = 4000 };
            Hitman h3 = new Hitman() { Hitman_ID = 3, Hitman_Name = "Jancsi", Style = "Martial Arts", Basic_Price = 67000 };
            Hitman h4 = new Hitman() { Hitman_ID = 4, Hitman_Name = "Dzson", Style = "Martial Arts", Basic_Price = 7500 };
            Hitman h5 = new Hitman() { Hitman_ID = 5, Hitman_Name = "J", Style = "Martial Arts", Basic_Price = 3000 };
            Hitman h6 = new Hitman() { Hitman_ID = 6, Hitman_Name = "László", Style = "Martial Arts", Basic_Price = 8000 };

            List<Hitman> hlist = new List<Hitman>() { h1, h2, h3, h4, h5, h6 };

            this.MoqHitman.Setup(x => x.GetAll()).Returns(hlist.AsQueryable());
            var teszt = this.testLogic.MostExpensive();

            List<string> expected = new List<string>()
            {
                 h1.Hitman_ID + " - " + h1.Hitman_Name,
                 h3.Hitman_ID + " - " + h3.Hitman_Name,
                 h4.Hitman_ID + " - " + h4.Hitman_Name,
                 h6.Hitman_ID + " - " + h6.Hitman_Name
            };
            Assert.That(teszt, Is.EqualTo(expected));
        }

        /// <summary>
        /// Testing AllContracts method.
        /// </summary>
        [Test]
        public void TestAllContracts()
        {
            Contract c1 = new Contract() { Contract_ID = 1, Contract_Name = "The Pope Contract", Target_ID = 1, Hitman_ID = 1 };
            Contract c2 = new Contract() { Contract_ID = 2, Contract_Name = "The Padasdantract", Target_ID = 2, Hitman_ID = 2 };
            Contract c3 = new Contract() { Contract_ID = 3, Contract_Name = "Thesemmiket", Target_ID = 3, Hitman_ID = 3 };

            Hitman h1 = new Hitman() { Hitman_ID = 1, Hitman_Name = "Józsi", Style = "Martial Arts", Basic_Price = 7000 };
            Hitman h2 = new Hitman() { Hitman_ID = 2, Hitman_Name = "Jasper", Style = "Martial Arts", Basic_Price = 4000 };
            Hitman h3 = new Hitman() { Hitman_ID = 3, Hitman_Name = "Jancsi", Style = "Martial Arts", Basic_Price = 67000 };

            Target t1 = new Target() { Target_ID = 1, Target_Name = "The Pope", Target_Location = "Rome", Risk = 0 };
            Target t2 = new Target() { Target_ID = 2, Target_Name = "Tanyue", Target_Location = "Hódmező", Risk = 0 };
            Target t3 = new Target() { Target_ID = 3, Target_Name = "akármi", Target_Location = "Ercsi", Risk = 0 };

            List<Hitman> hlist = new List<Hitman>() { h1, h2, h3 };
            List<Target> tlist = new List<Target>() { t1, t2, t3 };

            List<Contract> clist = new List<Contract>() { c1, c2, c3 };
            this.MoqContract.Setup(x => x.GetAll()).Returns(clist.AsQueryable());
            this.MoqHitman.Setup(x => x.GetAll()).Returns(hlist.AsQueryable());
            this.MoqTarget.Setup(x => x.GetAll()).Returns(tlist.AsQueryable());
            var teszt = this.testLogic.AllContracts();

            List<string> expected = new List<string>()
            {
                c1.Contract_Name + " - " + h1.Hitman_Name + " - " + t1.Target_Name,
                c2.Contract_Name + " - " + h2.Hitman_Name + " - " + t2.Target_Name,
                c3.Contract_Name + " - " + h3.Hitman_Name + " - " + t3.Target_Name,
            };
            Assert.That(teszt, Is.EqualTo(expected));
        }
    }
}
