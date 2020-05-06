﻿using System;
using Application;
using Domain;
using NUnit.Framework;

namespace DomainTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void PrototypeGeneral()
        {
            PrototypeSoldier prototypeSoldier = new PrototypeSoldier();
            Soldier soldier = (Soldier) prototypeSoldier.Prototype("General");
            Assert.AreEqual("General", soldier.Range);
        }
        
        [Test]
        public void PrototypeInitial()
        {
            PrototypeSoldier prototypeSoldier = new PrototypeSoldier();
            Soldier soldier = (Soldier) prototypeSoldier.Prototype("Initial");
            Assert.AreEqual("General", soldier.Range);
        }
    }
}