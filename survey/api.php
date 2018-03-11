<?php
/*
DB NAME = ChatExperiment
TABLE NAME = result
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
    if($key != "KEY")
        exit("Authentication Failed");

    //取得參數
    $objectID = $_GET['objectID'];
    $testobjectID = $_GET['testobjectID'];
    $sex = $_GET['sex'];
    $reason = $_GET['reason'];
    $ip = "'".GetIPAddress()."'";
    /*echo $objectID;
    echo $testobjectID;
	 echo $sex;
	 echo $reason;
	 echo $ip;*/
    //echo $detail;

    //連結資料庫認證
    $link = mysql_connect('HOST','USER','PASSWORD');
    if(!$link){
      die('connect error:'.mysql_error());
    }
    
    //echo 'ok\r\n';
    
    //選擇資料庫
    $db = mysql_select_db("ChatExperiment");
    if(!$db){
        die('db error\r\n');
    }
    
    //echo 'db ok\r\n';
    
    //進行寫入
    mysql_query("SET NAMES 'utf8'");
    mysql_query("INSERT INTO `ChatExperiment`.`result` (`id`, `time`, `odjectID`, `TestobjectID`, `sex`, `reason`, `ip`) VALUES (NULL, CURRENT_TIMESTAMP,$objectID,$testobjectID,$sex,$reason,$ip)") or die(mysql_error());
echo mysql_error();
    //echo "Write OK\r\n";
    //關閉資料庫
    mysql_close($link);
    exit("OK");
?>
/*  
    oxygen studio ChatExperiment Server 端程式
    2017/11/29
*/
