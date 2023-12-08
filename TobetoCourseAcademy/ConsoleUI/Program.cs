using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

//NewMethod();


//CourseManager cm = new CourseManager(new EfCourseDal());

//var result = cm.GetCourseDetail();

//if (result.Success == true)
//{

//    foreach (var item in result.Data)
//    {
//        Console.WriteLine(item.CourseName + " " + item.CategoryName);
//    }

//}
//else 
//{
//    Console.WriteLine(result.Message);
//}

InstructorManager cm = new InstructorManager(new EfInstructorDal());
var result = cm.GetAll();

foreach (var item in result.Data)
{
    Console.WriteLine(item.FirstName);
}


/*
static void NewMethod()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    //foreach (var product in categoryManager.GetAll())
    //{
    //    Console.WriteLine(product.Name);
    //}
    //Console.ReadLine(); 


    var ds = categoryManager.GetById(1);
    Console.WriteLine(ds.Name);


    CourseManager courseManager = new CourseManager(new EfCourseDal());
    //foreach (var item in courseManager.GetByUnitPrice(100, 350))
    //{

    //    Console.WriteLine(item.Name);
    //}
}*/

