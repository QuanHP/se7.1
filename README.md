# SỬA LỖI VÀ NÂNG CẤP GAME SUBWAY SURFERS
**Thành viên nhóm:**
- Phạm Hồng Quân
- Vũ Bảo Thắng
- Lê Thanh Thiên
- Nguyễn Hữu Quang
# 1. Mô tả game
- Đây là game nhập vai thể loại subway surfers, nhân vật của người chơi được đặt vào tình thế bị truy đuổi và phải chạy liên tục
- Trên đường chơi sẽ có các vật cả mà người chơi phải tránh, đồng thời có các vật phẩm mà người chơi có thể thu thập
## 1.1. Các kịch bản chơi game
Game có hai chế độ:
- Chế độ chơi cơ bản
- Chế độ chơi "Con đường phần thưởng" truy cập thông qua item Pharaong. Đây là một đường hạn hữu hạn thay vì vô hạn như màn chơi gốc, cuối đường chạy sẽ là một rương phần thưởng nhưng để đến được đó người chơi phải vượt qua rất nhiều cạm bẫy

## 1.2. Các usecase trong game
### 1.2.1 Màn hình chính:
+ Nhân vật luôn luôn di chuyển về phía trước trong màn chơi lặp lại vô hạn
+ Người chơi là di chuyển sang trái, phải, nhảy lên, lộn xuống tránh các vật cản để đạt thành tích chạy cao nhất có thể.  
+ Bên cạnh đó, trên đường chạy người chơi có thể thu thập và tích lũy các vật phẩm để giúp quá trình chạy dễ dàng.  
- Vàng: người chơi ăn vàng để có thể mua nhân vật mới, mua ván trượt, mua xe bay, nâng cấp đồ,..   
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
### 1.2.2 Màn hình cửa hàng:  
#### - Mua vật phẩm  
- Mua các vật phẩm như ván bay, rương bí ẩn, xe bay, điểm cộng  
#### - Nâng cấp  
- Nâng cấp các vật phẩm để tăng thời gian duy trì: thiết bị bay, giày nhảy cao, nam châm, nhân đôi điểm, xe máy bay, ván bay  
### 1.2.3 Màn chọn nhân vật
- 
### 1.2.4 Màn hình bảng xếp hạng:  
- Hiển thị điểm của người chơi  
- Hiển thị mục các bạn bè của người chơi, xếp hạng các bạn bè theo thứ tự giảm dần về điểm chạy  
- Hiển thị các quốc gia của bạn bè  
- Hiển thị những bạn bè đang trực tuyến  
# 2. Các sửa đổi cho game
Mô tả chi tiết các sửa đổi trong game, bao gồm hình ảnh, thuyết minh, thuật toán hoặc các Class hay method thêm/sửa/xóa
## 2.1. Thay đổi 1
__Thay thế map City thành map Citywinter__  
Cách làm:  
Bước 1: Lấy các texture liên quan đến tuyết để phủ lên bề mặt các vật trong map theo trục Z  
Bước 2: Chọn "Material" -> tạo một texture mới -> import ảnh tuyết đã tải về từ trước để làm texture phủ lên từng object. Sau đó, chuyển từ "Object Mode" sang "Edit Mode"  
Bước 3: Ở Edit Mode, có 3 lựa chọn là Vertex select, Edge select và Face select. Chọn Face select và tiến hành phủ tuyết bằng texture  
Chọn từng mặt của object muốn phủ, sau đó chọn texture tuyết vừa import vào -> chọn "Assign" để phủ texture lên từng object  
![image](https://github.com/QuanHP/se7.1/assets/148623697/9541d3d4-4e54-47e3-908c-b2b6df4cd1f9)

## 2.2. Thay đổi 2
__Tìm ra và sửa các lỗi game__ 
- Lỗi rơi ra khỏi map ở lối lên đường hầm => Sửa bằng cách thêm componet BarrierInformation cho các lối lên
- Lỗi đi xuyên qua thanh chắn đường hầm => Sửa bằng cách thêm các collision box tương ứng
- Lỗi đi xuyên vào xe bus khi nhanh tay lướt ngang ở đầu xe => Sửa bằng cách sửa lỗi logic trong script
- Chức năng tất bật xe bay hoạt động chưa đúng khiến người chơi bay xuyên qua các nắp hầm => Thêm các khối tunnelStart để quy định thêm về việc tắt xe bay
- Lỗi không tắt được trạng thái tìm đối thủ =>
## 2.3. Thay đổi 3
__Ẩn một số chức năng lỗi hoặc chưa hoàn thiện__
- Ẩn các vật phẩm mua bằng tiền mặt trong cửa hàng
- Ẩn chức năng record
## 2.4. Thay đổi 4
__Thêm login bằng usename và password__
- Thêm tính năng login bằng tài khoản và mật khẩu kết nối với firebase
- Thêm tính năng login bằng facebook nhưng chưa lấy được mã doanh nghiệp
## 2.4. Thay đổi 5
__Thêm nhân vật mới__
- Đã thêm được model của nhân vật mới vào game và thêm được vào cửa hàng nhưng do phát sinh lỗi liên quan đến scale nhân vật nên tạm thời loại bỏ khỏi cửu hàng

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

