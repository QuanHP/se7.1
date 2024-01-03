
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
- Nam châm: Dùng để hút vàng xung quanh người chơi  
![image](https://github.com/QuanHP/se7.1/assets/148623697/0328a08a-57b3-4d1e-9b2b-5268a2fadb08)
- Ván bay: Ấn 2 lần vào màn hình để triệu hồi ván bay. Ván bay giúp người chơi di chuyển nhanh hơn, nếu người chơi va chạm với vật thể trên đường thì ván bay tự phát nổ và người chơi sẽ được cứu.  
![image](https://github.com/QuanHP/se7.1/assets/148623697/a31d0006-b2c2-46b7-9a03-35e9b94e89fa)
- Bóng bay: Đùng để chuyển giữa các map  
![image](https://github.com/QuanHP/se7.1/assets/148623697/011beda6-2aa4-4e22-be97-24a97bb1ca7e)
- Giày nhảy cao: Giúp nhảy cao hơn bình thường để dễ dàng vượt địa hình  
![image](https://github.com/QuanHP/se7.1/assets/148623697/7b7cd5b3-98b6-46aa-b3fc-b520a886a474)
- Biểu tượng Pharaon: Khi chạm vào biểu tượng này, người chơi sẽ được chuyển đến map trên trời  
![image](https://github.com/QuanHP/se7.1/assets/148623697/1e0f2522-b3f4-4aed-874b-6af4fc961b54)
- Rương bí ẩn: Mở ra các vật phẩm như vàng, ván trượt, chìa khóa,..
![image](https://github.com/QuanHP/se7.1/assets/148623697/cb888a10-d39a-4d56-908e-49bca41eb848)
- Chìa khóa: Giúp hồi sinh trong trận  
![image](https://github.com/QuanHP/se7.1/assets/148623697/9ecd2077-338c-4a08-8d5c-86205c7c14df)
- Lò xo: Giúp bật nhảy lên cao
![image](https://github.com/QuanHP/se7.1/assets/148623697/16d1bd9b-4d5e-4eff-9b3e-b4eeedefae35)



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

## 3.2. Mở dự án trên Unity và chạy thử ngay trên Màn hình Unity Editor
Vào menu File-> Open Scene, chọn vào file Assets/Scene/LoadData.unity
Bấm nút Play của Unity để chạy thử

## 3.3. Build và chạy trên Android

Vào menu File -> Build Settings, chọn Platform là Android rồi nhấn "Switch Platform" để chuyển sang Android. Sau đó nhấn vào nút Build để thực hiện build ra file APK. Tham khảo trên Google search để biết cách cài đặt Build settings sao cho phù hợp
