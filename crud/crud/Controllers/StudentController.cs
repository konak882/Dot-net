﻿using crud.context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crud.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbObj = new db_testEntities();
        

        public ActionResult Student(tbl_student obj)
        { 
            if(obj != null)
                return View(obj); 
            else
                return View();
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_student model)
        {
            tbl_student obj = new tbl_student();
            if (ModelState.IsValid)
            {
                
                obj.ID = model.ID;
                obj.Name = model.Name;
                obj.Fname = model.Fname;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Description = model.Description;

                if(model.ID==0)
                {
                    dbObj.tbl_student.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }
                return View("Student"); 
            }
            ModelState.Clear();
            return View("Student");

        }
        public ActionResult StudentList()
        {
            var res= dbObj.tbl_student.ToList();
            return View(res);
        }
        public ActionResult Delete(int id) 
        {
            var res = dbObj.tbl_student.Where(X=>X.ID == id).First();
            dbObj.tbl_student.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.tbl_student.ToList();
            return View("StudentList",list);
        }
    }
}