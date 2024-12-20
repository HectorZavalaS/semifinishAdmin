$(document).ready(function () {
    //loadLoginDlg();
    initTable('tblCgsProgrs');
    initTable('tblModelos');
    initTable('tblSemifinish');
    initTable('tblSMTT');
    initTable('tblSMTB');
    initTable('tblMANU');
    initTable('tblFG');
    //$("#se_id_model").chosen();
    createSelect("#se_id_model");
    createSelect("#se_id_smtt");
    createSelect("#se_id_smtb");
    createSelect("#se_id_manu");
    createSelect("#se_id_fg");
    createSelect("#se_id_cgs_prg");
//    $(".edit").html("<span class='glyphicon glyphicon-pencil' style='margin:0;'></span>");
});
function initTable(tblName) {
    $('#' + tblName).DataTable({
        "paging": true,
        //"order": [[0, "asc"]],
        "recordsFiltered": 10,
        "lengthChange": false,
        "searching": true,
        "pageLength": 5,
        "ordering": true,
        "info": true,
        "autoWidth": true,
        //'language': { 'url': getVirtDir() + '/Scripts/Spanish.json' }
    });
}
function createSelect(id) {
    $(id).attr('data-live-search', true);
    $(id).attr('data-size', '10');
    $(id).attr('data-live-search-style', 'contains');
    $(id).attr('data-style', 'btn-info');
    $(id).css('width', '100%');
    $(id).selectpicker();
}