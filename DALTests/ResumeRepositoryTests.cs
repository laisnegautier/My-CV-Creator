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

        /// <summary>
        /// 1st method that test insertion into database and create some background to work on
        /// </summary>
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


            H2 langues = new H2("Langues", competences);
            Paragraph langue1 = new Paragraph("Anglais - Courant (TOEIC : 400/900 en 2019)", competences);
            Paragraph langue2 = new Paragraph("Occitan - Débutant", competences);
            competences.Elements.Add(langues);
            competences.Elements.Add(langue1);
            competences.Elements.Add(langue2);
            H2 informatique = new H2("Informatique", competences);
            Paragraph outilsInformatique = new Paragraph("Cubase, Dorico, Visual Studio 1995", competences);
            competences.Elements.Add(informatique);
            competences.Elements.Add(outilsInformatique);


            Date stage2ADate = new Date(DateTime.Now);
            stage2ADate.Container = experiences;
            H2 stage2ATitre = new H2("Stage de recherche en génie logiciel - ENSC, Talence", experiences);
            Paragraph stage2AFonction = new Paragraph("Stagiaire de qualité", experiences);
            stage2AFonction.Italic = true;
            Paragraph stage2ADescription = new Paragraph("Description du stage de 2A etc...", experiences);
            experiences.Elements.Add(stage2ADate);
            experiences.Elements.Add(stage2ATitre);
            experiences.Elements.Add(stage2AFonction);
            experiences.Elements.Add(stage2ADescription);

            Date stage1ADate = new Date(DateTime.Now, experiences);
            H2 stage1ATitre = new H2("Stage de recherche en bases de données - ENSC, Talence", experiences);
            Paragraph stage1AFonction = new Paragraph("Petit stagiaire", experiences);
            stage1AFonction.Italic = true;
            Paragraph stage1ADescription = new Paragraph("Description du stage de 1A etc...", experiences);
            experiences.Elements.Add(stage1ADate);
            experiences.Elements.Add(stage1ATitre);
            experiences.Elements.Add(stage1AFonction);
            experiences.Elements.Add(stage1ADescription);

            Line separateurExp = new Line(experiences);
            experiences.Elements.Add(separateurExp);

            H2 autresExperiences = new H2("Autres expériences", experiences);
            Date aE1Date = new Date(DateTime.Now, experiences);
            Paragraph aE1 = new Paragraph("Chanteur d'opéra", experiences);
            experiences.Elements.Add(autresExperiences);
            experiences.Elements.Add(aE1Date);
            experiences.Elements.Add(aE1);


            H2 musique = new H2("Musique", interets);
            Paragraph piano = new Paragraph("Piano depuis 10 ans", interets);
            Paragraph guitare = new Paragraph("Guitare depuis la naissance", interets);
            interets.Elements.Add(musique);
            interets.Elements.Add(piano);
            interets.Elements.Add(guitare);
            H2 sport = new H2("Sport", interets);
            Paragraph marche = new Paragraph("Marche depuis la naissance", interets);
            Paragraph etirement = new Paragraph("S'étire depuis quelques temps", interets);
            interets.Elements.Add(sport);
            interets.Elements.Add(marche);
            interets.Elements.Add(etirement);


            testResume.Save(cvJulien);
        }

        /// <summary>
        /// 2nd method that test insertion into database and create some background to work on
        /// </summary>
        [TestMethod()]
        public void Resume2CreationDatabase()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            // EMPTY RESUME-TEST
            Resume cvSylvie = new Resume("CV de Sylvie");

            testResume.Save(cvSylvie);

            // ADDING CONTAINERS
            Container contact = new Container("Information", cvSylvie);
            Container formations = new Container("Mon parcours", cvSylvie);
            Container experiences = new Container("Mes Expériences", cvSylvie);
            Container competences = new Container("Mes Compétences", cvSylvie);
            Container interets = new Container("Intérêts", cvSylvie);
            cvSylvie.Containers.Add(contact);
            cvSylvie.Containers.Add(formations);
            cvSylvie.Containers.Add(experiences);
            cvSylvie.Containers.Add(competences);
            cvSylvie.Containers.Add(interets);

            testResume.Save(cvSylvie);

            // ADDING ELEMENTS IN EACH CONTAINER
            H1 nomPrenom = new H1("Sylvie LAISNE", contact);
            H2 age = new H2("12 ans, né le 23/12/20..", contact);
            Paragraph adresse = new Paragraph("4 Rue de la GLog 76000 ROUEN", contact);
            Paragraph telephone = new Paragraph("07 12 12 12 12", contact);
            Paragraph mail = new Paragraph("sylvie.vie@fatal.com", contact);
            contact.Elements.Add(nomPrenom);
            contact.Elements.Add(age);
            contact.Elements.Add(adresse);
            contact.Elements.Add(telephone);
            contact.Elements.Add(mail);


            Date bacDate = new Date(DateTime.Now, formations);
            Paragraph bac = new Paragraph("Baccalauréat L parcours Musique et Danse", formations);
            formations.Elements.Add(bacDate);
            formations.Elements.Add(bac);


            H2 langues = new H2("Langues écrites et parlées", competences);
            Paragraph langue1 = new Paragraph("Anglais - Courant (TOEIC : 900/900 en 2012)", competences);
            Paragraph langue2 = new Paragraph("Allemand - Confirmé", competences);
            Paragraph langue3 = new Paragraph("Chinois - Débutant", competences);
            competences.Elements.Add(langues);
            competences.Elements.Add(langue1);
            competences.Elements.Add(langue2);
            competences.Elements.Add(langue3);
            H2 informatique = new H2("Informatique", competences);
            Paragraph outilsInformatique1 = new Paragraph("Word", competences);
            Paragraph outilsInformatique2 = new Paragraph("Protégé", competences);
            competences.Elements.Add(informatique);
            competences.Elements.Add(outilsInformatique1);
            competences.Elements.Add(outilsInformatique2);


            Date jobDate = new Date(DateTime.Now);
            jobDate.Container = experiences;
            H2 jobTitre = new H2("Job d'été", experiences);
            Paragraph jobFonction = new Paragraph("Vendanges", experiences);
            jobFonction.Italic = true;
            Paragraph jobDescription = new Paragraph("A joué avec des renards toute la journée.", experiences);
            experiences.Elements.Add(jobDate);
            experiences.Elements.Add(jobTitre);
            experiences.Elements.Add(jobFonction);
            experiences.Elements.Add(jobDescription);

            H2 musique = new H2("Musique", interets);
            Paragraph cithar = new Paragraph("Joue du cithar des fois", interets);
            interets.Elements.Add(musique);
            interets.Elements.Add(cithar);

            testResume.Save(cvSylvie);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();
            List<Resume> Resumes = testResume.GetAll();

            Assert.IsTrue(Resumes[0].Title == "CV de Julien");
            Assert.IsTrue(Resumes[1].Title == "CV de Sylvie");
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();
            Resume monResume1 = testResume.GetById(1);
            Resume monResume2 = testResume.GetById(2);
            Resume monResume20000 = testResume.GetById(20000);


            Assert.IsTrue(monResume1.Title == "CV de Julien");
            Assert.IsTrue(monResume2.Title == "CV de Sylvie");
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

            Resume resumeToModif = testResume.GetById(1);
            resumeToModif.Title = "CV de Julien";

            resumeToModif.Containers[0].Name = "modifTest";
            
            // Update an already existing resume
            testResume.Save(resumeToModif);

            Resume resumeModified = testResume.GetById(1);

            Assert.IsNotNull(resumeModified);
            Assert.IsTrue(resumeModified.Title == resumeToModif.Title);
            Assert.IsTrue(resumeToModif.Containers[0].Name == resumeToModif.Containers[0].Name);
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

        [TestMethod()]
        public void DeleteInCascadeTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            Resume resumeToDelete = testResume.GetById(1);
            testResume.Delete(resumeToDelete);

            Resume resumeToDeleteCheck = testResume.GetById(1);
            Assert.IsNull(resumeToDeleteCheck);
        }
    }
}