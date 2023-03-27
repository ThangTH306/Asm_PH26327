using Newtonsoft.Json;

namespace Asm_PH26327.Models.Services
{
    public class SessionCart
    {
        public static List<CartDetail> GetObjectFromSession(ISession session, string key)
        {
            string jsonData = session.GetString(key);//lay du lieu dang string tu session
            if (jsonData == null)
            {
                return new List<CartDetail>();//tao 1 list moi de chua san pham khi du lieu lay ra null => session chua duoc tao ra
            }
            else
            {//neu du lieu co thi ta se chuyen doi no ve dang list
                var cartdetails = JsonConvert.DeserializeObject<List<CartDetail>>(jsonData);
                return cartdetails;
            }
        }
        //2-Ghi de du lieu vao session tu 1 list
        public static void SetObjectToSession(ISession session, string key, object data)
        {
            var jsonData = JsonConvert.SerializeObject(data);//chuyen doi du lieu ve jsondata
            session.SetString(key, jsonData);//ghi de vao session
        }
        //3-Kiem tra xem 1 doi tuong co nam trong 1 list hay khong
        public static bool CheckObjectInList(Guid id, List<CartDetail> cartdetails)
        {
            return cartdetails.Any(x => x.IdSp == id);
        }
    }
}
