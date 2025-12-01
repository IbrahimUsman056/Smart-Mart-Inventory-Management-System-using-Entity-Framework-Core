using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
namespace SmartMart_App_EF
{
    public partial class Form1 : Form
    {
        MartContext context = new MartContext();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result1 =
             from c in context.Cust
             join s in context.Sal on c.CustomerId equals s.CustomerId
             join p in context.Prod on s.ProductId equals p.ProductId
             select new
             {
                 Name = c.Name,
                 City = c.City,
                 ProductName = p.ProductName,
                 SaleDate = s.SaleDate
             };

            dataGridView1.DataSource = result1.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result2 =
                from c in context.Cust
                join s in context.Sal on c.CustomerId equals s.CustomerId into saleGroup
                from sg in saleGroup.DefaultIfEmpty()
                join p in context.Prod on sg.ProductId equals p.ProductId into prodGroup
                from pg in prodGroup.DefaultIfEmpty()
                select new
                {
                    Name = c.Name,
                    City = c.City,
                    ProductName = pg != null ? pg.ProductName : "No Purchase",
                    SaleDate = sg != null ? sg.SaleDate : null
                };

            dataGridView2.DataSource = result2.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result3 =
                from c in context.Cust
                join s in context.Sal on c.CustomerId equals s.CustomerId into saleGroup
                select new
                {
                    Name = c.Name,
                    TotalPurchasedProducts = saleGroup.Count()
                };

            dataGridView3.DataSource = result3.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result4 =
                from p in context.Prod
                join s in context.Sal on p.ProductId equals s.ProductId
                group s by p.Category into g
                select new
                {
                    Category = g.Key,
                    TotalSales = g.Count()
                };

            dataGridView4.DataSource = result4.ToList();
        }
    }
}
