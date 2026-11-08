# Lịch sử thay đổi

## [1.2.0] - Chưa phát hành

### Đã thêm

- Inspector, thao tác chỉnh sửa, hộp thoại cài đặt, tên tư thế chuẩn và menu VRChat được tạo nay hiển thị bằng 30 ngôn ngữ.
- Thống nhất lựa chọn ngôn ngữ cho Inspector và menu trò chơi. Ban đầu dùng ngôn ngữ máy tính; lựa chọn gần nhất cũng dùng trong các dự án khác của cùng người dùng hệ điều hành.
- Có thể mở README, lịch sử thay đổi và hướng dẫn ngoại tuyến bằng ngôn ngữ đã chọn.
- Cung cấp tên hiển thị của 128 tư thế chuẩn và mô tả từng tính năng theo thuật ngữ hiện có.

### Tương thích

- Giữ thiết lập avatar hiện có, tên tùy chỉnh, tham chiếu tài nguyên, mã định danh tham số và phương thức lưu giấy phép.

## [1.1.0] - 2026-11-07

- Trong 50 tư thế, 43 tự chỉnh chi bằng IK theo vóc dáng avatar. 7 còn lại dùng hiệu chỉnh từng tư thế như trước.
- Điều chỉnh vị trí và hướng avatar bằng Chế độ chụp. Có thể chọn đồng bộ vị trí/hướng và hiển thị đầu mình khi chụp.
- “Độ cao sàn” di chuyển toàn thân lên xuống tối đa 3m, dùng riêng với “Độ cao chân”.
- Thêm hoạt ảnh thở, thiết lập ngừng đung đưa mặc định khi chờ và giảm méo tư thế do hướng cổ.
- Kiểm tra tính năng dùng và mức tham số trong Inspector. Hỗ trợ tìm tư thế, thêm hàng loạt, sắp xếp và xem trước đơn giản trong Scene.
- Tăng tốc chuyển đứng, khom và ngồi trong chế độ máy tính.
- Cải thiện cảnh báo tạo trước sau đổi thiết lập, tải khi cuộn Inspector và dừng lâu lúc dọn kết quả được tạo.
- Hỗ trợ Unisaki Posing System 3.1.0.
- Không kèm chuyển động Lật người cho tư thế đi kèm.

## [1.1.0-beta.2] - Beta mở (2026-11-05)

- Đặt hiệu chỉnh chi tự động (IK) cho 43 trong 50 tư thế. 7 còn lại dùng hiệu chỉnh từng tư thế như trước.
- Hỗ trợ gói chung 3.1.0-beta.2. Tư thế đi kèm lần này không có chuyển động Lật người.

## [1.1.0-beta.1] - Beta mở (2026-11-04)

- Hỗ trợ Unisaki Posing System 3.1.0-beta.1.
- Đổi chuyển tư thế thường trong chế độ máy tính sang một lần đánh giá. Có hiệu lực cho dựng thường và tạo trước; VR và điều kiện đặc biệt giữ đường xử lý cũ.
- Nhận diện dữ liệu tạo trước từ alpha.3 trở về trước là cần cập nhật.
- Giữ góc nhìn khi đổi Độ cao sàn lúc chụp, rồi trở về Độ cao sàn mới nhất khi kết thúc chụp.
- Áp dụng cải tiến đến alpha.3 về nhập tự động, hiệu chỉnh chuyển động nhập và quản lý Controller được tạo.

## [1.1.0-alpha.1] - Trước công bố

### Đã thêm

- Thêm Lật người và thiết lập hoạt ảnh tương ứng từng tư thế.
- Thêm biểu tượng menu riêng cho Thở, Lật người, Độ cao sàn, Chế độ chụp, Khoảng cách, Hướng và Thoát chụp.
- Thêm Chế độ chụp điều chỉnh tiến về trước và xoay.
- Thêm đồng bộ Chế độ chụp. Chỉ cục bộ 0 bit, đồng bộ 16 bit.
- Thêm giữ đầu avatar mình hiển thị trong Chế độ chụp.
- Thêm “Độ cao sàn” nâng toàn thân gồm đầu.
- Thêm hoạt ảnh thở, cường độ và menu ON/OFF trong trò chơi.
- Thêm Tắt đung đưa khi đứng yên của VRChat.
- Thêm Giảm méo tư thế do xoay đầu.
- Thêm ngăn đầu gối gập ngược và góc gập tối thiểu.
- Thêm ON/OFF từng tính năng và hiển thị mức dùng ExpressionParameters.
- Thêm xem trước đơn giản trong Scene, tìm tư thế, thêm hàng loạt và chỉ định vị trí đích.
- Thêm lịch sử thay đổi trong Inspector.

### Đã thay đổi

- Sắp Inspector thành 3 thẻ “Tính năng”, “Tư thế” và “Thiết lập avatar”.
- Sắp vị trí chi tiết thở, nhập chuyển động riêng và thiết lập sẵn.
- Giảm lặp hoạt ảnh tạo cho Độ cao chân.
- Thêm xác nhận khi cập nhật ảnh tư thế và gom cảnh báo vào “Kiểm tra thiết lập”.
- Bỏ menu thêm mới bản 8bit, thống nhất chọn tính năng trên Prefab thường. Giữ tham chiếu cũ.
- Hỗ trợ Unisaki Posing System 3.1.0-alpha.1. Đổi phiên bản VRChat Avatars SDK tối thiểu thành 3.10.4.

### Đã sửa

- Sửa nhập tên bị chuyển sang tư thế khác và chi tiết đóng khi sắp xếp.
- Sửa xem trước chồng, lệch vị trí đặt và lỗi ở một số avatar.
- Sửa cập nhật cảnh báo/trạng thái tạo trước sau đổi thiết lập và một số lỗi dựng.

## [1.0.0] - 2026-09-06

- Phát hành chính thức.
- Thêm thiết lập sẵn avatar (トネール, 狛乃, 士堂, 真央).

## [1.0.0-alpha.1] - 2026-09-06

- Phát hành.
