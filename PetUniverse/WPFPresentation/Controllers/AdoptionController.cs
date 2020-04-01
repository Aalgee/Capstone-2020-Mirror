﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataTransferObjects;
using LogicLayerInterfaces;
using LogicLayer;
using WPFPresentation.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace WPFPresentation.Controllers
{
    /// <summary>
    /// Creator: Awaab Elamin
    /// Created: 3/7/2020
    /// Approver: Mohamed Elamin, 3/10/2020
    /// 
    /// controlling Adoption Application and questionnair
    /// </summary>
    public class AdoptionController : Controller
    {
        private MVCAdoptionApplication adoptionApplication;
        private IAdoptionManager adoptionApplicationManager;
        private MVCQuestionnair questionnair;

        public AdoptionController()
        {
            adoptionApplication = new MVCAdoptionApplication();
            adoptionApplicationManager = new ReviewerManager();
            questionnair = new MVCQuestionnair();
        }


        /// <summary>
        /// Creator: Awaab Elamin
        /// Created: 3/7/2020
        /// Approver: Mohamed Elamin, 3/10/2020
        /// 
        /// main page of the adoption section
        /// </summary>
        // GET: Adoption
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Creator: Awaab Elamin
        /// Created: 3/7/2020
        /// Approver: Mohamed Elamin, 3/10/2020
        /// 
        /// controlling Adoption Application and questionnair
        /// </summary>
        //GET:AdoptionApplication
        [HttpGet]
        public ActionResult AdoptionApplication(LoginViewModel model) 
        {
            //var user = new ApplicationUser
            //{
            //    UserName = model.Email,
            //    Email = model.Email,

            //};
            this.adoptionApplication.CustomerEmail = model.Email;
            this.adoptionApplication.Status = "Reviewer";
            this.adoptionApplication.RecievedDate = DateTime.Today;
            //if (adoptionApplication != null)
            //{                
                this.adoptionApplication.qusetionnair = adoptionApplicationManager.retrieveCustomerQuestionnar(this.adoptionApplication.CustomerEmail);
            //}
            return View(this.adoptionApplication);
        }


        /// <summary>
        /// Creator: Awaab Elamin
        /// Created: 3/7/2020
        /// Approver: Mohamed Elamin, 3/10/2020
        /// 
        /// controlling Adoption Application and questionnair
        /// </summary>
        //Post:AdoptionApplication
        [HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult AdoptionApplication(MVCAdoptionApplication adoptionApplication)
        {
            if (adoptionApplicationManager.addAdoptionApplication(adoptionApplication))
            {
                
                ViewBag.StatusMessage = "update goes right!";
                return RedirectToAction("Index");
            }
            else
            {
                
                ViewBag.StatusMessage = "Model state is not valid";
                return RedirectToAction("Index");
               
                //return View();
            }
        }


        /// <summary>
        /// Creator: Awaab Elamin
        /// Created: 3/7/2020
        /// 
        /// controlling Adoption Application and questionnair
        /// </summary>
        //GET:Questionnair
        [HttpGet]
        public ActionResult Questionnair(LoginViewModel model)
        {
            List<String> questions = new List<String>();
            questions = adoptionApplicationManager.retrieveAllQuestions();
            if (model.Email == "")
            {
                questionnair = new MVCQuestionnair();
                
            }
            questionnair.Question1 = questions[0];
            questionnair.Question2 = questions[1];
            questionnair.Question3 = questions[2];
            questionnair.Question4 = questions[3];
            questionnair.Question5 = questions[4];
            questionnair.Question6 = questions[5];
            questionnair.Question7 = questions[6];
            questionnair.Question8 = questions[7];
            questionnair.Question9 = questions[8];
            questionnair.Question10 = questions[9];
            return View(questionnair);
        }


        //POST:Questionnair
        [HttpPost]
        public ActionResult Questionnair(MVCQuestionnair questionnair) 
        {
            if (adoptionApplicationManager.addQuestionnair(questionnair))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "You already filled the Questionnair";
                    return View(questionnair);
            }
        }

        
        
    }

}