using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Dtos
{
    public class CreateBusinessDto1529465De1
    {
        private string _Name;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên doanh nghiệp không được bỏ trống")]
        [MaxLength(255, ErrorMessage = "Tên doanh nghiệp không được vượt quá 255 ký tự")]
        public string Name
        {
            get => _Name;
            set => _Name = value?.Trim();
        }
        
        private string _TaxId;
        [Required(AllowEmptyStrings =false, ErrorMessage = "Mã số thuế không được bỏ trống")]
        public string TaxId
        {
            get => _TaxId;
            set => _TaxId = value;
        }
        
        private string _Address;
        public string Address
        {
            get => _Address;
            set => _Address = value?.Trim();
        }

    }
}
