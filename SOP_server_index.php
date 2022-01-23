<?php
include("SOP_server_connection.php");

$db = new dbObj();
$connection = $db->getConnection();
$request_method = $_SERVER["REQUEST_METHOD"];
$username = "Olga";
$password = "123";

switch($request_method){
    case 'GET':         
        if(!empty($_GET["id"])){
            $id = intval($_GET["id"]);
            get_game_by_id($id);
        }else
            get_all_game();
    break;
    
    case 'POST':
        insert_game();       
    break;
    
    case 'PUT': 
        update_game();
    break;
    
    case 'DELETE': 
        $id = intval($_GET["id"]);
        delete_game($id);
    break;
    
    default:
        header("HTTP/1.0 405 Method Not Allowed");
    break;
}
    


function get_all_game(){
    global $connection;
    $query = "SELECT * FROM jatekok";

    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_assoc($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);
}

function get_game_by_id($id=0){
    global $connection;
    $query = "SELECT * FROM jatekok";
    if($id != 0) $query.= " WHERE id =" . $id . " LIMIT 1"; 
    $response = array();
    $result = mysqli_query($connection, $query);
    while($row=mysqli_fetch_assoc($result)) 
        $response[] = $row;

    header('Content-Type: application/json');
    echo json_encode($response);

}

function insert_game(){
    global $connection;
    global $username;
    global $password;
    $data = json_decode(file_get_contents('php://input'), true);

    $requsername = $data["username"];
    $reqpassword = $data["password"];
    if($requsername == $username && $reqpassword == $password){

        $nev = $data["nev"];
        $mufaj = $data["mufaj"];
        $kiado = $data["kiado"];
        $jatekmod = $data["jatekmod"];
    
        $query="INSERT INTO jatekok SET nev='".$nev."', mufaj='".$mufaj."', kiado='".$kiado."', jatekmod='".$jatekmod."'";
    
        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Game inserted successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Game insertion failed'
            );
        }
    
        
        header('Content-Type: application/json');
           
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'Game insertion unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }
    echo json_encode($response); 

}


function update_game(){
    global $connection;
    global $username;
    global $password;
    $data = json_decode(file_get_contents('php://input'),true);
    
    $requsername = $data["username"];
    $reqpassword = $data["password"];
    if($requsername == $username && $reqpassword == $password){
        $nev = $data["nev"];
        $mufaj = $data["mufaj"];
        $kiado = $data["kiado"];
        $jatekmod = $data["jatekmod"];
        $id = intval($data["id"]);

        $query = "UPDATE jatekok SET nev='".$nev."', mufaj='".$mufaj."', kiado='".$kiado."', jatekmod='".$jatekmod."' WHERE id = '".$id."'";

        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Game updated successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Game update failed'
            );
        }
        
        header('Content-Type: application/json'); 
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'Game update unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }
    echo json_encode($response);    
}

function delete_game($id){
    global $connection;
    global $username;
    global $password;
    $data = json_decode(file_get_contents('php://input'), true);

    $requsername = $data["username"];
    $reqpassword = $data["password"];  

    if($requsername == $username && $reqpassword == $password){
        $query= "DELETE FROM jatekok WHERE id = ".$id;
        if(mysqli_query($connection, $query)){
            $response = array(
                'status' => 1,
                'status_message' => 'Game deleted successfully'
            );
        }else{
            $response = array(
                'status' => 0,
                'status_message' => 'Game deletion failed'
            );
        }
           header('Content-Type: application/json');
    }else{
        $response = array(
            'status' => 0,
            'status_message' => 'Game deletion unauthorized'
        );
        header("HTTP/1.0 401 Unauthorized");
    }

    
    echo json_encode($response);
}