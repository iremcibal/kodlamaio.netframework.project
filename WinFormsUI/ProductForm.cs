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
    public partial class ProductForm : Form
    {
        IProductService _productService;
        public ProductForm()
        {
            IProductDal _productDal = new AdoProductDal();
            
            ProductMapperProfiles productMapperProfiles = new ProductMapperProfiles();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(productMapperProfiles);
            });

            IMapper mapper = new Mapper(mapperConfig);

            _productService = new
                ProductManager(_productDal,
                new ProductBusinessRules(_productDal),
                mapper);



            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void Add_Click(object sender, EventArgs e)
        {
            CreateProductRequest createProductRequest = new CreateProductRequest()
            {
                Name = ProductNameTb.Text,
                CategoryID = CategoryIDTb.Text,
                UnitPrice = UnitPriceTb.Text,
                UnitsInStock = UnitsInStockTb.Text,
                
            };

            _productService.Add(createProductRequest);

        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<ListProductResponse> products = _productService.GetAll();
            ProductGridView.DataSource = products;
        }
    }
}
