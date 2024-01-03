
# SUBWAY SUFFER 

Tiêu đề vắn tắt dự án

**Thành viên nhóm:**
Liệt kê thành viên nhóm phát triển dự án
# 1. Mô tả game
Mô tả cô đọng trong 5-10 dòng

## 1.1. Các kịch bản chơi game
Mô tả chi tiết các kịch bản chơi của game, vd Death war,  Civil war...

## 1.2. Các usecase trong game
Các usecase chính, nhân vật có thể chơi như nào. Cần có hình ảnh đi kèm..

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
