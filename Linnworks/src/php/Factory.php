<?php
class Factory
{
    public static function GetResponse($ext, $data, $token, $server)
    {
        $opts = array(
		  'http'=>array(
			'method'=>"POST",
			'header'=>"Content-Type: application/x-www-form-urlencoded; charset=UTF-8\r\n" .
					  "User-Agent: Linnworks PHP API SDK \r\n" . 
					  "Referer: https://www.linnworks.net/ \r\n" .
					  "Content-Length: " . strlen($data) . "\r\n" .
					  "Authorization: " . $token . "\r\n"
					  ,
			'content' => $data
		  )
		);
		
		$context = stream_context_create($opts);
		
		$url = "";
				
		if(!empty($token))
		{
			$url = $server . '/api/' . $ext;
		} else {
			$url = 'https://api.linnworks.net/api/' . $ext;
		}
		
		$response = file_get_contents($url, FALSE, $context);
		
		return $response;
    }
}
?>