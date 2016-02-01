var Factory = 
{
	GetResponse: function(ext, token, server, body) {
		var url = "";
		
		if(server)
		{
			url = server + "/api/" + ext;
		} else {
			url = "https://api.linnworks.net/api/" + ext;
		}
		
		var resp = "";
		
		$.ajax({
			url: url,
			type: 'post',
			data: body,
			headers: 
			{
				"Authorization" : token
			},
			dataType: 'application/x-www-form-urlencoded',
			complete: function (data) {
				resp = data.responseText;
			},
			async: false
		});	
		
		return JSON.parse(resp);
	}
}