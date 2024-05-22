﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotalProject.DataAccessLayer.Abstract;
using HotalProject.DataAccessLayer.Concrete;
using HotalProject.DataAccessLayer.Repositories;
using HotalProject.EntityLayer.Concrete;

namespace HotalProject.DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {

        }

    }
}
