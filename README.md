
# SUBWAY SUFFER 

Tiêu đề vắn tắt dự án

**Thành viên nhóm:**
Liệt kê thành viên nhóm phát triển dự án
# 1. Mô tả game
Mô tả cô đọng trong 5-10 dòng

## 1.1. Các kịch bản chơi game
Mô tả chi tiết các kịch bản chơi của game, vd Death war,  Civil war...

## 1.2. Các usecase trong game
- Vàng: người chơi ăn vàng để có thể mua nhân vật mới, mua ván trượt, mua xe bay,...  
![image](https://github.com/QuanHP/se7.1/assets/148623697/9b503683-f93f-4baa-b133-eea57d0899c7)
- Chìa khóa: Giúp hồi sinh trong trận  
![image](https://github.com/QuanHP/se7.1/assets/148623697/67061ce9-3f73-4968-81be-4681cc943117)
- Nam châm: Dùng để hút vàng xung quanh người chơi  
![image](https://github.com/QuanHP/se7.1/assets/148623697/0328a08a-57b3-4d1e-9b2b-5268a2fadb08)
- Ván bay: Ấn 2 lần vào màn hình để triệu hồi ván bay. Ván bay giúp người chơi di chuyển nhanh hơn, nếu người chơi va chạm với vật thể trên đường thì ván bay tự phát nổ và người chơi sẽ được cứu.  
![image](https://github.com/QuanHP/se7.1/assets/148623697/a31d0006-b2c2-46b7-9a03-35e9b94e89fa)
- Xe máy bay: Giúp người chơi bay được đoạn ngắn  
![image](https://github.com/QuanHP/se7.1/assets/148623697/15aa7494-b6bb-491f-8493-ebd927aed884)
- Thiết bị bay: Giúp người chơi bay được một khoảng dài  
![image](https://github.com/QuanHP/se7.1/assets/148623697/e93b2f15-b9f1-428b-a27b-04ec0b7728ec)
- Giày nhảy cao: Giúp nhảy cao hơn bình thường để dễ dàng vượt địa hình  
![image](https://github.com/QuanHP/se7.1/assets/148623697/7b7cd5b3-98b6-46aa-b3fc-b520a886a474)
- Nhân đôi điểm: Giúp người chơi nhân đôi điểm chạy  
![image](https://github.com/QuanHP/se7.1/assets/148623697/3b326a28-a941-48e9-98ac-aef8f595ac87)
- Rương bí ẩn: Mở ra các vật phẩm như vàng, ván trượt, chìa khóa,..  
![image](https://github.com/QuanHP/se7.1/assets/148623697/57108974-a794-4193-9d07-89f1d6ab1b29)
- Bóng bay: Đùng để chuyển giữa các map  
![image](https://github.com/QuanHP/se7.1/assets/148623697/011beda6-2aa4-4e22-be97-24a97bb1ca7e)
- Biểu tượng Pharaon: Khi chạm vào biểu tượng này, người chơi sẽ được chuyển đến map trên trời  
![image](https://github.com/QuanHP/se7.1/assets/148623697/1e0f2522-b3f4-4aed-874b-6af4fc961b54)
- Lò xo: Giúp bật nhảy lên cao  
![image](https://github.com/QuanHP/se7.1/assets/148623697/297c37ca-e01f-4b48-b88d-5c51eacd5053)  

# 2. Các sửa đổi cho game
Mô tả chi tiết các sửa đổi trong game, bao gồm hình ảnh, thuyết minh, thuật toán hoặc các Class hay method thêm/sửa/xóa
## 2.1. Thay đổi 1
__Thay thế map City thành map Citywinter__  
Cách làm:  
Bước 1: Lấy các texture liên quan đến tuyết để phủ lên bề mặt các vật trong map theo trục Z  
Bước 2: Chọn "Material" -> tạo một texture mới -> import ảnh tuyết đã tải về từ trước để làm texture phủ lên từng object. Sau đó, chuyển từ "Object Mode" sang "Edit Mode"  
Bước 3: Ở Edit Mode, có 3 lựa chọn là Vertex select, Edge select và Face select. Chọn Face select và tiến hành phủ tuyết bằng texture  
Chọn từng mặt của object muốn phủ, sau đó chọn texture tuyết vừa import vào -> chọn "Assign" để phủ texture lên từng object  
## 2.2. Thay đổi 2

# 3. Hướng dẫn Khởi tạo dự án
## 3.1. Cài Unity bản từ 2022 trở đi
Đăng ký tài khoản Unity bằng account sinh viên để có thể tham gia chương trình Education License của Unity

## 3.2. Cấu hình để sử dụng được firebase và facebook login
Cách cấu hình để đăng nhập bằng firebase:
-	Vào trang https://console.firebase.google.com/ và tạo một project
-	Tạo một realtime database. Chỉnh setting rules thành true.
-	Vào project settings và tải xuống google-service.json và firebase SDK về và cài  các package cần thiết như (FirebaseAuth,FirebaseDatabase,,..).
-	đặt file google-service.json vào assets. 
-	Giải nén file firebase SDK. Sau đó vào Assets và chọn import package > Custom package > .unitypackage file
Cách cấu hình để đăng nhập bằng facebook:
-	Truy cập vào trang https://developers.facebook.com/docs/unity/ vài tải xuống facebook sdk.
-	Truy cập vào https://developers.facebook.com/ và tạo app.
-	Setting và đăng app. (khi đăng app cần xác nhận doanh nghiệp, app bọn em k vượt qua được bước này nên khi đăng nhập bằng facebook bị lỗi).

## 3.3. Mở dự án trên Unity và chạy thử ngay trên Màn hình Unity Editor
Vào menu File-> Open Scene, chọn vào file Assets/Scene/LoadData.unity
Bấm nút Play của Unity để chạy thử

## 3.4. Build và chạy trên Android

Vào menu File -> Build Settings, chọn Platform là Android rồi nhấn "Switch Platform" để chuyển sang Android. Sau đó nhấn vào nút Build để thực hiện build ra file APK. Tham khảo trên Google search để biết cách cài đặt Build settings sao cho phù hợp
