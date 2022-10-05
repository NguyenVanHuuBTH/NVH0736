namespace NVH0736.Models.Process;

public class GiaiPhuongTrinh
{
    // xay dung phuong thuc tinh  tong 2 so nguyen
    //1. Xac dinh kieu tra ve của phuong trinh
    //2. Xac dinh cac tham so dau vao
    //3. Xay dung phan than phuong thuc
    //4. tra du lieu ve tuong ung
    // xay dung phuong thuc giai phuong trinh bac 1
    public string GiaiPhuongTrinhBacNhat (Double hesoA, Double hesoB)
    {
        double x;
        string thongBao = "";
        if(hesoA==0)
        {
            if(hesoB==0)
            {
                  thongBao = "Phuong trinh co vo so nghiem";
            }else{
                  thongBao = "Phuong trinh vo nghiem";
            }
        }else{
            x = -hesoB/hesoA;
            thongBao = "Phuong trinh co nghiem x = " + x;
        }
        return thongBao;
    }

    public string GiaiPhuongTrinhBacHai (Double a, Double b, Double c)
    {
        double x1, x2, delta;
        string ketqua = "";
         if(a==0)
        {
            if(b==0)
            {
                if(c==0)
                {
                    ketqua = "Phuong trinh co vo so nghiem.";
            }else{
                  ketqua = "Phuong trinh vo nghiem.";
            }
        }else{
            x1 = (double)-c / b;
            ketqua = "Phuong trinh co nghiem x = " + Math.Round(x1, 2);
        }
    }
    else
    {
        delta = Math.Pow(b, 2) - 4*a*c;
        if(delta < 0)
        {
            ketqua = "Phuong trinh vo nghiem.";
        }
        else if(delta == 0)
        {
            x1 = x2 = -b / (2*a);
            ketqua = "Phuong trinh co nghiem kep x1 = x2 = " + x1;
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2*a);
            x2 = (-b - Math.Sqrt(delta)) / (2*a);
            ketqua = "Phuong trinh hai nghiem phan biet: " + "x1 = " + x1 + " và x2 = " + x2;     
        }
    }
    return ketqua;
}
}