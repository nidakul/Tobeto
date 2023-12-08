using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseContext>, ICourseDal
    {
        public List<CourseDetailDTO> GetCourseDetail()
        {
            using (TobetoCourseContext context = new TobetoCourseContext())
            {
                var result = from c1 in context.Courses
                             join c2 in context.Categories
                             on c1.CategoryId equals c2.Id
                             select new CourseDetailDTO { CourseId=c1.Id, CourseName=c1.Name, CategoryName=c2.Name, Price=c1.Price };
                return result.ToList();
            }
        }
    }
}
