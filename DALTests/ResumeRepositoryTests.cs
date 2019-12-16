using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Tests
{
    [TestClass()]
    public class ResumeRepositoryTests
    {
        [TestMethod()]
        public void Resume1CreationDatabase()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            // EMPTY RESUME-TEST
            Resume cvJulien = new Resume("CV de Julien");

            testResume.Save(cvJulien);

            // ADDING CONTAINERS
            Container contact = new Container("CONTACT", cvJulien);
            Container formations = new Container("FORMATIONS", cvJulien);
            Container experiences = new Container("EXPERIENCES PROFESSIONNELLES", cvJulien);
            Container competences = new Container("COMPETENCES", cvJulien);
            Container interets = new Container("CENTRES D’INTERET", cvJulien);
            cvJulien.Containers.Add(contact);
            cvJulien.Containers.Add(formations);
            cvJulien.Containers.Add(experiences);
            cvJulien.Containers.Add(competences);
            cvJulien.Containers.Add(interets);

            testResume.Save(cvJulien);

            // ADDING ELEMENTS IN EACH CONTAINER
            H1 nomPrenom = new H1("Julien NOMDEFAMILLE", contact);
            H2 age = new H2("34 ans, né le 12/12/12", contact);
            Paragraph adresse = new Paragraph("1 Rue de la Galaxy 33 000 BORDEAUX", contact);
            Paragraph telephone = new Paragraph("07 85 85 85 85", contact);
            Paragraph mail = new Paragraph("julien.vie@fatal.com", contact);
            contact.Elements.Add(nomPrenom);
            contact.Elements.Add(age);
            contact.Elements.Add(adresse);
            contact.Elements.Add(telephone);
            contact.Elements.Add(mail);


            Date enscDate = new Date(DateTime.Now, formations);
            Paragraph ensc = new Paragraph("ENSC - Institut National Polytechnique de Bordeaux (33000), spécialité « Génie Logiciel »", formations);
            formations.Elements.Add(enscDate);
            formations.Elements.Add(ensc);
            Date universiteDate = new Date(DateTime.Now, formations);
            Paragraph universite = new Paragraph("Université de Pau - Pau (00000), Licence de Bio", formations);
            formations.Elements.Add(universiteDate);
            formations.Elements.Add(universite);
            Date bacDate = new Date(DateTime.Now, formations);
            Paragraph bac = new Paragraph("Baccalauréat Scientifique mention passable", formations);
            formations.Elements.Add(bacDate);
            formations.Elements.Add(bac);


            Paragraph langues = new Paragraph("Langues", competences);
            langues.Bold = true;
            Paragraph langue1 = new Paragraph("Anglais - Courant (TOEIC : 400/900 en 2019)", competences);
            Paragraph langue2 = new Paragraph("Occitan - Débutant", competences);
            competences.Elements.Add(langues);
            competences.Elements.Add(langue1);
            competences.Elements.Add(langue2);
            Paragraph informatique = new Paragraph("Informatique", competences);
            informatique.Bold = true;
            Paragraph outilsInformatique = new Paragraph("Cubase, Dorico, Visual Studio 1995", competences);
            competences.Elements.Add(informatique);
            competences.Elements.Add(outilsInformatique);


            Date stage2ADate = new Date(DateTime.Now, experiences);
            Paragraph stage2ATitre = new Paragraph("Stage de recherche en génie logiciel - ENSC, Talence", experiences);
            stage2ATitre.Bold = true;
            Paragraph stage2AFonction = new Paragraph("Stagiaire de qualité", experiences);
            stage2AFonction.Italic = true;
            Paragraph stage2ADescription = new Paragraph("Description du stage de 2A etc...", experiences);
            experiences.Elements.Add(stage2ADate);
            experiences.Elements.Add(stage2ATitre);
            experiences.Elements.Add(stage2AFonction);
            experiences.Elements.Add(stage2ADescription);

            Date stage1ADate = new Date(DateTime.Now, experiences);
            Paragraph stage1ATitre = new Paragraph("Stage de recherche en bases de données - ENSC, Talence", experiences);
            stage1ATitre.Bold = true;
            Paragraph stage1AFonction = new Paragraph("Petit stagiaire", experiences);
            stage1AFonction.Italic = true;
            Paragraph stage1ADescription = new Paragraph("Description du stage de 1A etc...", experiences);
            experiences.Elements.Add(stage1ADate);
            experiences.Elements.Add(stage1ATitre);
            experiences.Elements.Add(stage1AFonction);
            experiences.Elements.Add(stage1ADescription);

            Line separateurExp = new Line(experiences);
            experiences.Elements.Add(separateurExp);

            Paragraph autresExperiences = new Paragraph("Autres expériences", experiences);
            autresExperiences.Bold = true;
            Date aE1Date = new Date(DateTime.Now, experiences);
            Paragraph aE1 = new Paragraph("Chanteur d'opéra", experiences);
            experiences.Elements.Add(autresExperiences);
            experiences.Elements.Add(aE1Date);
            experiences.Elements.Add(aE1);


            Paragraph musique = new Paragraph("Musique", interets);
            musique.Bold = true;
            Paragraph piano = new Paragraph("Piano depuis 10 ans", interets);
            Paragraph guitare = new Paragraph("Guitare depuis la naissance", interets);
            interets.Elements.Add(musique);
            interets.Elements.Add(piano);
            interets.Elements.Add(guitare);
            Paragraph sport = new Paragraph("Sport", interets);
            sport.Bold = true;
            Paragraph marche = new Paragraph("Marche depuis la naissance", interets);
            Paragraph etirement = new Paragraph("S'étire depuis quelques temps", interets);
            interets.Elements.Add(sport);
            interets.Elements.Add(marche);
            interets.Elements.Add(etirement);


            testResume.Save(cvJulien);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();
            List<Resume> Resumes = testResume.GetAll();

            Assert.IsTrue(Resumes[0].Title == "Mon_CV1");
            Assert.IsTrue(Resumes[1].Title == "Mon_CV2");
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();
            Resume monResume1 = testResume.GetById(1);
            Resume monResume2 = testResume.GetById(2);
            Resume monResume20000 = testResume.GetById(20000);

            H1 h1 = (H1)monResume2.Containers[3].Elements[1];

            Assert.IsTrue(monResume1.Title == "Mon_CV1");
            Assert.IsTrue(monResume2.Title == "Mon_CV2");
            Assert.IsTrue(monResume2.Containers[3].Elements[1].Id == 5);
            Assert.IsTrue(h1.Content == "h1Cont7Pos1");
            Assert.IsTrue(h1.Bold == false);
            Assert.IsNull(monResume20000);
        }

        [TestMethod()]
        public void GetTheLastFiveTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            List<Resume> Resumes = testResume.GetTheLastFive();

            Assert.AreEqual(Resumes.Count, 2);
            Assert.IsTrue(Resumes[0].Title == "Mon_CV1");
            Assert.IsTrue(Resumes[1].Title == "Mon_CV2");
        }

        [TestMethod()]
        public void GetTheFavoriteOnesTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            List<Resume> Resumes = testResume.GetTheFavoriteOnes();

            Assert.AreEqual(Resumes.Count, 2);
            Assert.IsTrue(Resumes[0].Title == "Mon_CV1");
            Assert.IsTrue(Resumes[1].Title == "Mon_CV2");
        }

        [TestMethod()]
        public void InsertTest()
        {
            Resume monResume = new Resume("essai");

            IResumeRepository testResume;
            testResume = new ResumeRepository();
            testResume.Save(monResume);
            
            Resume resumeFromDB = testResume.GetById(3);

            Assert.IsNotNull(resumeFromDB);
            Assert.IsTrue(resumeFromDB.Title == "essai");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            Resume resumeToModif = testResume.GetById(7);
            resumeToModif.Title = "test";
            
            // Update an already existing resume
            testResume.Save(resumeToModif);

            Resume resumeModified = testResume.GetById(7);

            Assert.IsNotNull(resumeModified);
            Assert.IsTrue(resumeModified.Title == resumeToModif.Title);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();
 
            Resume resumeToDelete = testResume.GetById(7);

            testResume.Delete(resumeToDelete);

            Resume resumeToDeleteCheck = testResume.GetById(7);

            Assert.IsNull(resumeToDeleteCheck);
        }

        /** 
         * TO DOOOOOOOO
         */
        [TestMethod()]
        public void DeleteInCascadeTest()
        {
            throw new System.NotImplementedException();
        }
    }
}