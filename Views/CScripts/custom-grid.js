$(function () {
    var grid = $("#websiteContentGrid").dxDataGrid("instance");

    if (grid) {
        // Ví dụ: highlight hàng đầu tiên
        grid.on("contentReady", function () {
            let rows = grid.getVisibleRows();
            if (rows.length > 0) {
                grid.selectRowsByIndexes([0]);
            }
        });

        // Ví dụ: thêm thông báo khi click vào dòng
        grid.on("rowClick", function (e) {
            DevExpress.ui.notify("Bạn vừa chọn: " + e.data.Title, "success", 1000);
        });
    }
});
