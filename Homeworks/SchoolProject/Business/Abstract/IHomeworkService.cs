﻿using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IHomeworkService
    {
        void SendHomework(Student student);
    }
}
