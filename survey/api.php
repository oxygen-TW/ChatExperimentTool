<?php
/*
DB NAME = ChatExperiment
TABLE NAME = result
USER = ChatExperimentUser
PASSWORD = 
*/
    //取得IP
    function GetIPAddress(){
        if (!empty($_SERVER["HTTP_CLIENT_IP"])){
            $ip = $_SERVER["HTTP_CLIENT_IP"];
        }elseif(!empty($_SERVER["HTTP_X_FORWARDED_FOR"])){
            $ip = $_SERVER["HTTP_X_FORWARDED_FOR"];
        }else{
            $ip = $_SERVER["REMOTE_ADDR"];
        }
        return $ip;
    }

    //API驗證
    $key = $_GET['key'];
    if($key != "ChatExperimentTool")
        exit("Authentication Failed");

    //取得參數
    $objectID = $_GET['objectID'];
    $testobjectID = $_GET['testobjectID'];
    $sexuality = $_GET['sexuality'];
    $reason = $_GET['reason'];
	 $exchange = $_GET['exchange'];
	 $contact = $_GET['contact'];
	 $message = $_GET['message'];
    $ip = "'".GetIPAddress()."'";
    /*echo $objectID;
    echo $testobjectID;
	 echo $sex;
	 echo $reason;
	 echo $ip;
	 echo $exchange;
	 echo $contact;
	 echo $message;*/
    //echo $detail;

    //連結資料庫認證
    $link = mysql_connect('HOST','USER','PASSWORD');
    if(!$link){
      die('connect error:'.mysql_error());
    }
    
    //echo 'ok\r\n';
    
    //選擇資料庫
    $db = mysql_select_db("KEYt");
    if(!$db){
        die('db error\r\n');
    }
    
    //echo 'db ok\r\n';
    
    //進行寫入
    mysql_query("SET NAMES 'utf8'");
    //mysql_query("INSERT INTO `ChatExperiment`.`result` (`id`, `ip`, `time`, `odjectID`, `TestobjectID`, `sexuality`, `reason`, `exchange`, `contact`, `message`) VALUES (NULL,$ip, CURRENT_TIMESTAMP,$objectID,$testobjectID,$sexuality,$reason,$exchange,$contact,$message)") or die(mysql_error());
    mysql_query("INSERT INTO `ChatExperiment`.`result` (`id`, `ip`, `time`, `odjectID`, `TestobjectID`, `sexuality`, `reason`, `exchange`, `contact`, `message`) VALUES (NULL,$ip, CURRENT_TIMESTAMP,$objectID,$testobjectID,$sexuality,$reason,$exchange,$contact,$message)") or die(mysql_error());

    //echo "Write OK\r\n";
    //關閉資料庫
    mysql_close($link);
    exit("OK");
?>
/*  
    oxygen studio ChatExperiment Server 端程式
    2018/03/12
*/
