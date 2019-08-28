// on modal open hold name and id in modal elements for post
$('#DeleteModal').on('show.bs.modal', function (e) {
    var data = $(e.relatedTarget).data();
    $('#ContactName', this).text(data.contactName);
    $('#ContactId').val(data.contactId);
});
