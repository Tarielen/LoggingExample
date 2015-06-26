var nowDate = new Date();
//example data
var newLog = {
    app: "User Management Portal",
    type: "User Account ID",
    accId: Account.ID,
    eventID: 220,
    routine: 'Project-Scripts-UMP-Logging.js',
    loc: Admin.LoginLocationID,
    time: moment(nowDate).tz("America/Vancouver").format("YYYY-MM-DD HH:mm:ss.SSS"), //using Moment.js for datetime handling
    user: Admin.UserID
} 
bindingModel = JSON.stringify(newLog);
AddLog(bindingModel);

function AddLog(bindingModel) {
    $.ajax({
        type: "POST",
        url: "/Shared/AddLog",
        dataType: "json",
        data: { bindingModel: bindingModel },
        success: function (response) {
            console.log("Logging SUCCESS");
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            console.log("Logging FAILED");
        }
    })
}