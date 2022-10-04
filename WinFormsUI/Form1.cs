using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Profiles;
using Business.Request.Product;
using Business.Response.Product;
using DataAccess.Abstract;
using DataAccess.Concrete.Adonet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        //private ICategoryService _categoryService;
        //private ICustomerService _customerService;
        private IProductService _productService;
        public Form1()
        {
            //ICategoryDal categoryDal = new AdoCategoryDal();
            //ICustomerDal customerDal = new AdoCustomerDal();
            IProductDal productDal = new AdoProductDal(); 
            AutoMapperProfiles autoMapperProfiles = new AutoMapperProfiles();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(autoMapperProfiles);
            });
            IMapper mapper = new Mapper(mapperConfig);
            _productService = new ProductManager(productDal, new ProductBusinessRules(productDal),mapper);
            //_categoryService = new CategoryManager(categoryDal, new CategoryBusinessRules(categoryDal), mapper);
            //_customerService = new CustomerManager(customerDal, new CustomerBusinessRules(customerDal));
            InitializeComponent();
        }


        private void btnDataReader_Click(object sender, EventArgs e)
        {
            foreach (ListProductResponse item in _productService.GetAll())
            {
                Console.WriteLine(item.ID + " "+ item.Name + " " + item.UnitPrice);
            } 

            //AdoProductDal productDal = new AdoProductDal();
            //foreach (var item in productDal.GetAll())
            //{
            //    Console.WriteLine("Product : " + item.ProductID + " " + item.ProductName);
            //}

            //AdoCategoryDal categoryDal = new AdoCategoryDal();
            //foreach (var item in categoryDal.GetAll())
            //{
            //    Console.WriteLine("Category : " + item.CategoryID + " " + item.CategoryName);
            //}

            //AdoCustomerDal customerDal = new AdoCustomerDal();
            //foreach (var item in customerDal.GetAll())
            //{
            //    Console.WriteLine("Customer : " + item.CustomerID + " " + item.ContactName);
            //}

            //AdoEmployeeDal employeeDal = new AdoEmployeeDal();
            //foreach (var item in employeeDal.GetAll())
            //{
            //    Console.WriteLine("Employee : " + item.EmployeeID + " " + item.FirstName + " " + item.LastName); ;
            //}
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            _productService.Add(
                request: new CreateProductRequest { Name = "Computer", CategoryID = 2 });

        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            _productService.Update(
                request: new UpdateProductRequest { Name = "Computer", UnitsInStock = 5,ID=2 });

        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {

            _productService.Delete(
                request: new DeleteProductRequest { Id = 80 });
        }
    }
}
