﻿using HotalProject.DataAccessLayer.Abstract;
using HotalProject.DataAccessLayer.Concrete;
using HotalProject.DataAccessLayer.Repositories;
using HotalProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {

        }



    }
}