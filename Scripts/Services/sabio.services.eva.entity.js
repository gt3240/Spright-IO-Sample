if (!sabio.services.eva)
    sabio.services.eva = {}

if (!sabio.services.eva.entity)
    sabio.services.eva.entity = {}

sabio.services.eva.entity.add = function (payload, onSuccess, onError) {
    $.ajax({
        type: 'POST',
        data: payload,
        dataType: "json",
        url: '/api/eva/entity/',
        success: onSuccess,
        error: onError
    });
};

