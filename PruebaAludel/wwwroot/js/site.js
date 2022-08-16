// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $(document).on('submit', '#comments-form', function () {
        Comment();
        return false;
    });

    $(document).on('submit', '#posts-form', function () {
        Post();
        return false;
    });

    $(document).on('submit', '#users-form', function () {
        User();
        return false;
    });
});



function Comment() {

    $.ajax({
        url: "/Comment/Get",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.postId + '</td>';
                html += '<td>' + item.id + '</td>';
                html += '<td>' + item.name + '</td>';
                html += '<td>' + item.email + '</td>';
                html += '<td>' + item.body + '</td>';
                html += '</tr>';
            });
            $('#comments-tbody').html(html);
            document.getElementById('comments-table').style.display = 'block';
            $('#comments-table').DataTable();
            

        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}



function Post() {
    
    $.ajax({
        url: "/Post/Get",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.userId + '</td>';
                html += '<td>' + item.id + '</td>';
                html += '<td>' + item.title + '</td>';
                html += '<td>' + item.body + '</td>';
                html += '</tr>';
            });
            $('#posts-tbody').html(html);
            document.getElementById('posts-table').style.display = 'block';
            $('#posts-table').DataTable();

        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}

function User() {

    $.ajax({
        url: "/User/Get",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.id + '</td>';
                html += '<td>' + item.name + '</td>';
                html += '<td>' + item.username + '</td>';
                html += '<td>' + item.email + '</td>';
                html += '<td>' + item.address.city + '</td>';
                html += '<td>' + item.phone + '</td>';
                html += '<td>' + item.website + '</td>';
                html += '<td>' + item.company.name + '</td>';
                html += '</tr>';
            });
            $('#users-tbody').html(html);
            document.getElementById('users-table').style.display = 'block';
            $('#users-table').DataTable();
            
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}


function GetUsernameById() {

    var idUser = $('#userId').val();

    $.ajax({
        url: "/User/GetById",
        data: { id: idUser },
        type: "GET",
        success: function (result) {

            if (result != '') {
                $.each(result, function (key, item) {
                    Swal.fire(
                        'Username',
                        `The username with id ${idUser} is ${item.name}`,
                        'info'
                    );
                });
            } else {
                Swal.fire(
                    'Username',
                    `The username with id ${idUser} do not exists`,
                    'error'
                );
            }        
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}

function GetCommentNameById() {

    var idComment = $('#commentId').val();

    $.ajax({
        url: "/Comment/GetById",
        data: { id: idComment },
        type: "GET",
        success: function (result) {

            if (result != '') {
                $.each(result, function (key, item) {
                    Swal.fire(
                        'Comment Name',
                        `The comment name with id ${idComment} is ${item.name}`,
                        'info'
                    );
                });
            } else {
                Swal.fire(
                    'Comment Name',
                    `The comment with id ${idComment} do not exists`,
                    'error'
                );
            }
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}

function GetPostTitleById() {

    var idPost = $('#postId').val();

    $.ajax({
        url: "/Post/GetById",
        data: { id: idPost },
        type: "GET",
        success: function (result) {

            if (result != '') {
                $.each(result, function (key, item) {
                    Swal.fire(
                        'Title',
                        `The post title with id ${idPost} is ${item.title}`,
                        'info'
                    );
                });
            } else {
                Swal.fire(
                    'Post',
                    `The post with id ${idPost} do not exists`,
                    'error'
                );
            }
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}



