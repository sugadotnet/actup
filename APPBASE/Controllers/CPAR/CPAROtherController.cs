﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APPBASE.Models;
using APPBASE.Helpers;
using APPBASE.Filters;
//using APPBASE.Svcapp;
using APPBASE.Svcbiz;
using AutoMapper;


namespace APPBASE.Controllers
{
    public partial class CPAROtherController : CPARController
    {
        public CPAROtherController()
        {
            CPAR_TYPE = valFLAG.FLAG_CPAR_TYPE_LL;
            ViewBag.Subtitle = "Lain-lain";
        } //End public CPAROtherController()
    } //End public partial class CPAROtherController : Controller
} //End namespace APPBASE.Controllers

