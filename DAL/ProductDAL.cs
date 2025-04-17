using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {

        private readonly DuAnMauContext _context;

        public ProductDAL()
        {
            _context = new DuAnMauContext();
        }
        //Lamda
        public List<Product> GetAllProducts() => _context.Products.ToList();
        //viết cụ thể
        //public List<Product> Get()
        //{
        //    return _context.Products.ToList();
        //}

        //Add => thêm 
        //_context.

        //public List<ProductDTO> GetAllProducts()
        //{
        //    List<ProductDTO> products = new List<ProductDTO>();
        //    using (SqlConnection conn = DatabaseHelper.GetConnection())
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM Product";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            products.Add(new ProductDTO
        //            {
        //                ProductID = (int)reader["ProductID"],
        //                ProductName = reader["ProductName"].ToString(),
        //                Price = (decimal)reader["Price"],
        //                ImagePath = reader["ImagePath"].ToString()
        //            });
        //        }
        //    }
        //    return products;
        //}

        // Create
        public async Task AddProduct(Product product)
        {
            using (var context = new DuAnMauContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void UpdateProduct(ProductDTO product)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Product SET ProductName=@name, Price=@price, ImagePath=@image WHERE ProductID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", product.ProductID);
                cmd.Parameters.AddWithValue("@name", product.ProductName);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@image", product.ImagePath);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Product WHERE ProductID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        //public void Update(Product product)
        //{
        //    _context.Products.Update(product);
        //    _context.SaveChanges();
        //}

        //public void Delete(int id)
        //{
        //    var product = _context.Products.Find(id);
        //    if (product != null)
        //    {
        //        _context.Products.Remove(product);
        //        _context.SaveChanges();
        //    }
        //}

        //public void AddProduct(ProductDTO product)
        //{
        //    using (SqlConnection conn = DatabaseHelper.GetConnection())
        //    {
        //        conn.Open();
        //        string query = "INSERT INTO Product(ProductName, Price, ImagePath) " +
        //            "VALUES (@name, @price, @image)";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@name", product.ProductName);
        //        cmd.Parameters.AddWithValue("@price", product.Price);
        //        cmd.Parameters.AddWithValue("@image", product.ImagePath);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
    }
}
