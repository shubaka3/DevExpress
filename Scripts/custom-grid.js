$(document).ready(function () {
    
    $(document).on("click", ".btn-edit", function () {
        const title = $(this).data("key");
      
        $('#modalMessage').text("Edit: " + title);
        $('#actionModal').modal('show');  
        
        $('#confirmButton').off('click').on('click', function () {
            alert("Chỉnh sửa " + title);
            $('#actionModal').modal('hide');
        });
    });

    
    $(document).on("click", ".btn-delete", function () {
        const title = $(this).data("key");
        $('#modalMessage').text("xóa: " + title + "?");
        $('#actionModal').modal('show'); 
       
        $('#confirmButton').off('click').on('click', function () {
           
            alert("Đã xóa " + title);
            $('#actionModal').modal('hide'); 
        });
    });

  
    $(document).on("click", ".btn-view", function () {
    
        const title = $(this).data("key");
        const slogan = $(this).data("slogan");
        const mainContent = $(this).data("maincontent");
        const seoTitle = $(this).data("seotitle");
        const seoKeywords = $(this).data("seokeywords");
        const modalMessage = `
            <strong>Tiêu đề:</strong> ${title}<br>
            <strong>Khẩu hiệu:</strong> ${slogan}<br>
            <strong>Nội dung chính:</strong> ${mainContent}<br>
            <strong>SEO Title:</strong> ${seoTitle}<br>
            <strong>SEO Keywords:</strong> ${seoKeywords}
        `;

        $('#modalMessage').html(modalMessage);

        $('#actionModal').modal('show');
    });
});
