namespace CoV.Service.DataModel
{
    public class ShipperSalaryViewModel
    {
        public string Name { get; set; }
        public int TotalMoney { get; set; } // tien ship thu
        public int TotalShip { get; set; } // tien tra ship
        public int TotalOrder { get; set; } // Tong so don
        public int TotalProduct { get; set; } //so luong san pham
    }
}