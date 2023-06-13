$(document).ready(function () {
    $("#comment-form").submit(function (e) {
        e.preventDefault(); // Prevent the default form submission

        var commentText = $("#comment-input").val(); // Get the comment text from the input field

        // Send an AJAX request to the server to save the comment
        $.ajax({
            type: "POST",
            url: "/Animal/AddComment",
            data: { animalId: @Model.Animal.Id, comment: commentText
    },
        success: function () {
            // Clear the comment input field after successful submission
            $("#comment-input").val('');

            // Update the comments list by fetching the latest comments
            loadComments();
        }
            });
        });

// Function to load the latest comments
function loadComments() {
    $.ajax({
        type: "GET",
        url: "/Animal/GetComments",
        data: { animalId: @Model.Animal.Id
},
success: function (commentsHtml) {
    // Replace the existing comments list with the updated comments
    $("#comments-list").html(commentsHtml);
}
            });
        }

// Initial load of comments
loadComments();
    });
