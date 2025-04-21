using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Models
{
    public class WebsiteContent
    {
        public string Title { get; set; }  // Tiêu đề của website
        public string LogoUrl { get; set; }  // Đường dẫn logo của website
        public string Slogan { get; set; }  // Khẩu hiệu của website
        public string MainContent { get; set; }  // Nội dung chính của website
        public List<string> HeaderLinks { get; set; }  // Các liên kết trong header
        public List<string> FooterLinks { get; set; }  // Các liên kết trong footer
        public List<string> MenuLinks { get; set; }  // Các liên kết trong menu
        public string SeoTitle { get; set; }  // Tiêu đề SEO của website
        public string SeoDescription { get; set; }  // Mô tả SEO của website
        public string SeoKeywords { get; set; }  // Từ khóa SEO của website

        // Constructor để khởi tạo giá trị mặc định nếu cần
        public WebsiteContent()
        {
            HeaderLinks = new List<string>();
            FooterLinks = new List<string>();
            MenuLinks = new List<string>();
        }
 
}
}