<?php
    //API驗證
    $key = $_GET['key'];
    if($key != "orangeisatypeoffruit")
        exit("Authentication Failed");

    //系統參數
	$DBhost = 'localhost';
	$DBuser = 'ES-User';
	$DBpwd = 'B5iA1d5NyCK1nHkM';
	$DBname = 'Emotion-Scale';

    $DB_Table = $_GET['mode'];
    if ($DB_Table != "stress" && $DB_Table != "depression")
        exit("Mode Error");

	$link = mysql_connect($DBhost,$DBuser,$DBpwd);
	if(!$link){
  		die('DB connect:ok->'.mysql_error());
	}

	//echo 'DB connect:ok<br>';

	$db = mysql_select_db($DBname);
	if(!$db){
		die('DB select:error<br>');
	}

	//echo 'DB select:ok<br>';

	mysql_query("SET NAMES 'utf8'");

	$result = mysql_query("select * from $DB_Table");
	//echo 'DB read:ok<br>';
	
	$AllData = array();
	while($row = mysql_fetch_array($result)){
		$data = array(
            "ID" => $row['ID'],
            "name" => $row['Name'],
            "IP_address" => $row['IP'],
			"upload_time" => $row['Time'],
			"score" => $row['Score'],
			"detail" => $row['Detail']
			);
		array_push($AllData,$data);
	}
	echo json_encode( $AllData);
?>
/*  
    oxygen studio 青少年情緒量表 Server 端程式
    2017/11/29
*/