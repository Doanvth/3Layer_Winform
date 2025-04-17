using DAL;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        private ProductDAL dal = new ProductDAL();

        // cách viết cụ thể
        //public static List<NhanVienDTO> GetAll()
        //{
        //    return NhanVienDAL.GetAllNhanVien();
        //}

        // cách viết rút gọn
        //public List<ProductDTO> GetAll() => dal.GetAllProducts();

        // cách viết linq 
        public List<Product> GetAll() => dal.GetAllProducts();

        public void Add(Product product) => dal.AddProduct(product);
        public void Update(ProductDTO product) => dal.UpdateProduct(product);
        public void Delete(int id) => dal.DeleteProduct(id);
    }
}
