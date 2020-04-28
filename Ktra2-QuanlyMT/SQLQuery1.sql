


SELECT tblNhan_vien.MaNV,tblNhan_vien.TenNV,SUM(So_luong)as tongtienban FROM(tblNhan_vien INNER JOIN tblHDB ON tblNhan_vien.MaNV = tblHDB.MaNV) INNER JOIN tblChitietHDB ON tblHDB.Ma_HDB = tblChitietHDB.Ma_HDB GROUP BY tblNhan_vien.MaNV,TenNV HAVING SUM(So_luong) >= ALL (SELECT sum(So_luong) FROM(tblNhan_vien INNER JOIN tblHDB ON tblNhan_vien.MaNV = tblHDB.MaNV) INNER JOIN tblChitietHDB ON tblHDB.Ma_HDB = tblHDB.Ma_HDB GROUP BY tblNhan_vien.MaNV,tblNhan_vien.TenNV)
select * from tblHDB
select top 5 tblNhan_vien.MaNV,TenNV,sum(tblHDB.Tong_tien) as tongsotien from tblNhan_vien join tblHDB on tblNhan_vien.MaNV=tblHDB.MaNV WHERE (YEAR(tblHDB.NgayBan)=2020) group by tblNhan_vien.MaNV,TenNV Order by tongsotien desc 