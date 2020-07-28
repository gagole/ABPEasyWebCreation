(function ($) {

    if (!$) {
        return;
    }

    $(function () {

        var $resetPasswordForm = $('#ResetPasswordForm');

        $resetPasswordForm.validate({
            rules: {
                UserName: {
                    required: true,
                    customUsername: true
                }
            },

            highlight: function (input) {
                $(input).parents('.form-line').addClass('error');
            },

            unhighlight: function (input) {
                $(input).parents('.form-line').removeClass('error');
            },

            errorPlacement: function (error, element) {
                $(element).parents('.form-group').append(error);
            }
        });
    });

})(jQuery);