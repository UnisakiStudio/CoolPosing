# Cool Posing Tool

Công cụ khóa tư thế VRChat cho phép dùng dáng ngầu cả khi theo dõi 3 điểm và chế độ máy tính. Gồm tổng 50 tư thế: 11 đứng, 9 khom, 14 ngồi, 9 nằm ngửa và 7 nằm sấp.

README này dành cho v1.2.0 đang phát triển. Chưa xác định ngày phát hành chính thức. Xem phiên bản đã cài ở đầu Inspector.

- [Trang sản phẩm BOOTH](https://yunisaki.booth.pm/items/8797334)
- [Lịch sử thay đổi](CHANGELOG.md)

## Ngôn ngữ hiển thị và tài liệu ngoại tuyến

Chọn ngôn ngữ hiển thị bằng “Language / 言語” ở đầu Inspector. Một lựa chọn áp dụng cho cả Inspector và menu VRChat được tạo. Tải avatar lên lại để thay đổi ngôn ngữ trong trò chơi.

Nếu chưa chọn, hệ thống dùng ngôn ngữ máy tính; ngôn ngữ không được hỗ trợ sẽ dùng tiếng Anh. Hỗ trợ Windows, macOS và Linux. Ngôn ngữ chọn gần nhất được lưu trong EditorPrefs và dùng cho các dự án khác của cùng người dùng hệ điều hành trên máy này. Tất cả công cụ tạo dáng và avatar dùng chung một ngôn ngữ. Thay đổi trong Inspector của bất kỳ công cụ nào sẽ cập nhật tùy chọn chung; lựa chọn ngôn ngữ riêng của từng avatar không được sử dụng. Không đồng bộ sang máy khác. Cách lưu giấy phép không thay đổi. Nút ngôn ngữ chỉ xuất hiện ở bước xác nhận cài đặt đầu tiên khi chưa lưu ngôn ngữ. Các lần đổi ngôn ngữ sau được thực hiện trong Inspector.

Bạn có thể chọn README, lịch sử thay đổi và hướng dẫn từ [danh sách ngôn ngữ](../index.html) đi kèm. “Hướng dẫn” và “Lịch sử thay đổi” trong Inspector cũng theo ngôn ngữ đã chọn. Điều khoản gốc và bản dịch tham khảo vẫn được cung cấp riêng như trước.

## Tính năng chính

- Hiệu chỉnh chi tự động (IK): chỉnh vị trí và hướng chi theo vóc dáng avatar trong 43 tư thế.

- Chế độ chụp: di chuyển avatar tối đa 3m về trước và điều chỉnh hướng. Chỉ màn hình bạn dùng 0 bit; hiển thị vị trí/hướng cho người khác dùng 16 bit.
- Hiển thị đầu khi chụp: ngăn đầu avatar của bạn biến mất khi ở gần, chỉ trong Chế độ chụp.
- Độ cao sàn: di chuyển toàn thân gồm đầu lên xuống tối đa 3m. Dùng riêng với “Độ cao chân”, chỉnh phía chân trong khi giữ đầu.
- Lật người: dùng được ở tư thế bạn tự đặt chuyển động tương thích. Tư thế đi kèm không có chuyển động Lật người.
- Thở: thêm chuyển động thở cho ngực và các phần khác. Chọn “Không, Nhẹ, Vừa, Mạnh, Nhanh, Tùy chỉnh” theo loại tư thế.
- Tắt đung đưa khi đứng yên của VRChat: giảm đung đưa mặc định khi chờ nhưng vẫn dùng được thở của công cụ và chuyển động tùy chỉnh khác.
- Giảm méo tư thế do xoay đầu: hạn chế méo khi mở khóa cổ mà hướng cổ khác tư thế gốc.
- Chọn tính năng: chỉ thêm menu trò chơi cần dùng và kiểm tra mức dùng ExpressionParameters trong Inspector.
- Tìm, thêm hàng loạt và sắp xếp tư thế: tìm xuyên loại, nhập nhiều clip và chỉ định vị trí đích.
- Xem trước đơn giản trong Scene: kiểm tra ngay tư thế từ “Xem trước” trong danh sách.

- Biểu tượng menu tính năng mới: Thở, Lật người, Độ cao sàn, Chế độ chụp và các mục khác có ảnh riêng phù hợp biểu tượng sản phẩm hiện có.

### Thiết lập Lật người

Mở “Chi tiết” tư thế nằm muốn dùng, bật “Bật lật người”, đặt hoạt ảnh trong “Tư thế lật người sang bên”. MotionTime thường không dùng được. Bật cả “Tính năng > Tính năng menu > Lật người” rồi tải lên. Trong VRChat, chọn tư thế tương thích và “Lật người”. Hãy mở khóa cổ khi dùng.

Tư thế đi kèm lần này không có chuyển động Lật người. Hãy đặt hoạt ảnh phù hợp tư thế muốn dùng.

## Thiết lập sẵn avatar hỗ trợ và hiệu chỉnh

Có thiết lập sẵn đã hiệu chỉnh cho トネール, 狛乃, 士堂 và 真央.

- [トネール](https://booth.pm/ja/items/5236104)
- [狛乃](https://booth.pm/ja/items/5260363)
- [士堂](https://booth.pm/ja/items/8086741)
- [真央](https://booth.pm/ja/items/6846646)

Có thể dùng avatar khác. Chỉnh tư thế bằng “Hiệu chỉnh hoạt ảnh” theo vóc dáng và nội dung chỉnh sửa. Trong “Thiết lập avatar” cũng có “Ngăn đầu gối gập ngược” và “Độ gập đầu gối tối thiểu (độ)” ở chi tiết.

Hiệu chỉnh chi tự động (IK) mặc định bật. Trong 50 tư thế, 43 dùng IK; 7 còn lại dùng hiệu chỉnh từng tư thế như trước.

## Cách cài đặt

1. Tải tệp từ trang sản phẩm của cửa hàng đã mua.
2. Nhập “カッコいいポーズツール.unitypackage” đi kèm vào Unity, đăng ký giấy phép và nguồn phân phối gói.
3. Qua VCC hoặc ALCOM, thêm Cool Posing Tool và Modular Avatar vào dự án Unity sẽ dùng. Unisaki Posing System chung và NDMF cũng được cài như gói phụ thuộc.
4. Nhấp phải avatar đích trong Hierarchy, chọn “Unisaki Studio > Thêm Cool Posing”.
5. Chọn “カッコいいポーズ” (Cool Posing) được thêm trong avatar và thiết lập tính năng/tư thế muốn dùng ở Inspector.
6. Tải avatar lên như thường.

Yêu cầu Unity 2022.3, VRChat Avatars SDK 3.10.4 trở lên, Modular Avatar dòng 1.x phiên bản 1.15.1 trở lên và NDMF dòng 1.x phiên bản 1.14.0 trở lên. Cập nhật các gói cần thiết cùng nhau qua VCC hoặc ALCOM.

## Cập nhật từ phiên bản cũ

Cập nhật sản phẩm và Unisaki Posing System cùng nhau. Thiết lập của công cụ đã đặt được giữ. Kiểm tra tính năng và mức dùng ExpressionParameters trong Inspector; nếu từng dùng tạo trước, nhấn “Cập nhật dữ liệu tạo trước” rồi tải lên lại.

Từ v1.1.0, thêm mới được thống nhất vào Prefab thường “カッコいいポーズ” (Cool Posing). Tắt mục không cần trong “Tính năng” để cấu hình tối thiểu chỉ chọn tư thế dùng 8 bit. Cấu hình nhiều tư thế có thể cần thêm bit chọn tư thế.

Prefab 8bit cũ giữ trong “Editor/Legacy” để duy trì tham chiếu avatar và thiết lập sẵn hiện có. Không cần xóa/thay Prefab đang dùng. Bản 8bit không hiển thị trong menu thêm mới Unity.

## Vị trí thiết lập

| Thẻ | Chức năng |
| --- | --- |
| Tính năng | Thêm menu trò chơi, tiện ích, thiết lập thở, ảnh biểu tượng và kiểm tra mức dùng ExpressionParameters |
| Tư thế | Chọn tư thế, chi tiết, tìm, thêm hàng loạt, đổi thứ tự, xem trước và hiệu chỉnh hoạt ảnh |
| Thiết lập avatar | Hiệu chỉnh riêng avatar/gối, nhập tư thế gốc hoặc chuyển động riêng và đổi thiết lập sẵn |

Nhấn “Mở thiết lập” để mở thiết lập chi tiết ngay bên dưới mục đó. Thiết lập thở qua “Tính năng > Tiện ích > Thêm hoạt ảnh thở”.

“Dùng tư thế đứng, ngồi xổm và nằm sấp gốc” tự nhập tư thế vốn có trên avatar. Để dùng chuyển động riêng, mở “Mở thiết lập nhập” riêng và chọn cho từng loại như đứng, ngồi xổm (Crouching), nằm sấp (Prone).

Thiết lập sẵn nằm cuối “Thiết lập avatar”. “Áp dụng thiết lập sẵn này” thay thiết lập tư thế hiện tại, nên hãy lưu nội dung đã chỉnh trước khi chuyển.

### Mức sử dụng từng tính năng

- Hoạt ảnh thở dùng 0 bit. Chỉ khi dùng “Tính năng menu > Thở” để dừng/tiếp tục trong trò chơi, đồng bộ ON/OFF dùng 1 bit.
- Chế độ chụp chỉ trên màn hình mình dùng 0 bit. Chọn “Tiện ích > Đồng bộ chế độ chụp” dùng 16 bit. “Giữ đầu hiển thị trong chế độ chụp” dùng 0 bit.
- “Độ cao chân” và “Độ cao sàn” mỗi mục dùng 8 bit. Độ cao sàn di chuyển toàn thân lên xuống khi lệch khỏi giữa và kết thúc khi về gần 50%.
- “Lật người” riêng dùng 10 bit. Dùng chung 1 bit với “Giảm méo tư thế do xoay đầu”, nên cả hai vẫn tổng 10 bit.
- “Lật đối xứng” và “Tắt cử chỉ” mỗi mục dùng 1 bit.

Tổng trong Inspector chỉ gồm công cụ tư thế đã cài trên avatar, không tính trang phục/công cụ khác. Dùng nhiều công cụ tư thế cũng không tính trùng thiết lập chung.

### Xem trước và sửa tư thế

“Xem trước” tại từng mục trong “Tư thế” hiển thị tư thế trong Scene. Để sửa chi tiết, mở “Hiệu chỉnh hoạt ảnh”, điều chỉnh trong khi kiểm tra rồi lưu.

Xem trước đơn giản không chạy dựng MA/NDMF. Hãy kiểm tra cả kết quả dựng trước tải lên với trang phục và hiệu chỉnh vị trí sàn được ghép lúc dựng.

Tìm tên tư thế bằng thẻ kính lúp bên trái. Chọn vị trí đích qua “Thứ tự” trong “Chi tiết” hoặc dùng nút lên/xuống để sắp xếp. Thêm nhiều hoạt ảnh cùng lúc bằng kéo thả vào vùng thêm hoặc “Nhập clip đang chọn trong Project”.

“Cập nhật ảnh thu nhỏ tư thế” tạo ảnh sau hộp thoại xác nhận. “Tạo biểu tượng tư thế” giúp nhận biết trong menu trò chơi nhưng tăng thời gian dựng do tạo ảnh. Chọn “Giảm kích thước biểu tượng” để tiết kiệm dung lượng. Không tạo biểu tượng tư thế cho Android.

## Điều khiển cơ bản trong trò chơi

- Chọn tư thế từng loại trong menu Expressions. Trong VR, đứng, khom, ngồi và nằm thay đổi theo độ cao đầu.
- Khi nằm, hướng mặt chuyển nằm ngửa/nằm sấp. Nếu chọn cả hai, cũng đổi được bằng nhảy; có thể tắt qua “Tính năng → Tiện ích → Nhảy để đổi tư thế nằm”. Chỉnh độ cao chuyển loại bằng ngưỡng trong menu thiết lập.
- Trong chế độ máy tính, dùng C và Z đổi tư thế. Nếu Z không chuyển sang nằm, tăng ngưỡng độ cao nằm trong menu thiết lập.
- Bật “Tắt cử chỉ” để dùng hình bàn tay của tư thế thay hình ngón tay từ bộ điều khiển.
- “Độ cao chân” chỉnh phía chân trong khi giữ đầu. “Độ cao sàn” di chuyển toàn thân gồm đầu lên xuống. Chúng xuất hiện theo thứ tự này trong menu thiết lập.
- Di chuyển về trước bằng “Khoảng cách” trong “Chế độ chụp” khiến avatar quay về phía bạn. Xoay bằng “Hướng” và bật “Khóa chân” lúc cần. “Thoát chụp” khôi phục khoảng cách/hướng và mở khóa chân.
- “Thở” dùng được nếu hoạt ảnh thở bật. Chọn cường độ trong Unity và bật/tắt ON/OFF trong trò chơi.

## Tạo trước và cảnh báo

“Cập nhật dữ liệu tạo trước” tái dùng dữ liệu đã tạo để dựng avatar nhanh hơn. Ngay cả không tạo trước, dữ liệu cần thiết vẫn sinh trong lần dựng thường.

Sau đổi thiết lập, “Kiểm tra thiết lập” ở đầu Inspector hoặc dấu Hierarchy thông báo cần cập nhật. “Thiết lập hiển thị cảnh báo” nằm trong khung “Kiểm tra thiết lập”. Ẩn không giải quyết vấn đề hay cập nhật dữ liệu.

## Lưu ý sử dụng

- Không hỗ trợ khóa tư thế khi theo dõi toàn thân.
- Có thể cần chỉnh thêm theo vóc dáng, trang phục và thay đổi avatar.
- Có thể không tích hợp như ý với layer Base đặc biệt hoặc công cụ đổi tư thế khác. Nếu khóa không ổn, kiểm tra “Thiết lập avatar > Tích hợp khóa theo dõi với công cụ khác”.
- Di chuyển/xoay của Chế độ chụp và Độ cao sàn hiệu chỉnh tư thế công cụ và chuyển động mặc định/tùy chỉnh khi chưa chọn tư thế. Kiểm tra góc nhìn cuối và hành vi sau thay chuyển động trong ứng dụng VRChat.
- “Tắt đung đưa khi đứng yên của VRChat” nhắm chuyển động chờ mặc định, không dừng mọi đung đưa từ nguyên nhân khác.

## Hướng dẫn và hỗ trợ

Mở hướng dẫn, liên hệ và lịch sử thay đổi từ “Trợ giúp / lịch sử thay đổi” ở đầu Inspector. Chi tiết tính năng chung cũng có trong “Packages > Unisaki Posing System > README” tại Project Unity.

- [Hướng dẫn chính thức](https://docs.unisakistudio.jp/coolposing/manual/)
- [Liên hệ](https://help.unisakistudio.jp/)

Khi báo lỗi, cung cấp phiên bản sản phẩm này và Unisaki Posing System, phiên bản Unity, VRChat SDK, Modular Avatar và NDMF, avatar dùng, bước tái hiện và nội dung lỗi Console.

## Điều khoản sử dụng

Sản phẩm gồm điều khoản VN3 “ゆにさきスタジオ販売・配布データ利用規約（日本語版）Ver1.0.0.pdf”, áp dụng chung cho dữ liệu Unisaki Studio bán/phân phối. Hãy đọc kỹ trước sử dụng.

Mã nguồn và tài nguyên kho này không phải mã nguồn mở. Người mua hợp lệ được cấp quyền dùng trong phạm vi điều khoản đi kèm.
