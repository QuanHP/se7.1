
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
![CoinPharaoh](https://github.com/QuanHP/se7.1/assets/148623697/216af76b-610d-4730-bbec-3fad82d793ba)
- Nam châm: Dùng để hút vàng xung quanh người chơi  
![image](https://github.com/QuanHP/se7.1/assets/148623697/dc8f8ae9-cbc1-47bb-8343-47b8828537af)
- Ván trượt: Ấn 2 lần vào màn hình để triệu hồi ván trượt. Ván trượt giúp người chơi di chuyển nhanh hơn, nếu người chơi va chạm với vật thể trên đường thì ván trượt tự phát nổ và người chơi sẽ được cứu.
![image](https://github.com/QuanHP/se7.1/assets/148623697/74eae87c-7c45-4082-a00f-5916a5c870fd)
- Bóng bay: Đùng để chuyển giữa các map
![image](https://github.com/QuanHP/se7.1/assets/148623697/6426e6ab-fa91-40e1-be18-036f26912748)
- Giày nhảy cao: Giúp nhảy cao hơn bình thường để dễ dàng vượt địa hình
![image](https://github.com/QuanHP/se7.1/assets/148623697/7e3ede39-6ae9-405c-8bc1-fde850d7f5b7)
- Biểu tượng Pharaon: Khi chạm vào biểu tượng này, người chơi sẽ được chuyển đến map trên trời  
![image](https://github.com/QuanHP/se7.1/assets/148623697/3aba62a3-6134-4bd8-9e20-374b86458c7a)
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
