<?php
  	session_start();
	
	// This includes your database connection
  	if(isset($_SESSION['admin'])){
    	header('location: admin/home.php');
  	}

    if(isset($_SESSION['voter'])){
      header('location: home.php');
    }
	if (isset($_POST['fingerprint_data'])) {
		$fingerprint_data = $_POST['fingerprint_data'];
	
		// The SQL query would depend on how fingerprint data can be compared
		$query = $conn->prepare("SELECT voter_id FROM fingerprints WHERE fingerprint_match_function(fingerprint_data, ?) = 1");
		$query->bind_param("s", $fingerprint_data);
		$query->execute();
		$result = $query->get_result();
	
		if ($result->num_rows > 0) {
			$row = $result->fetch_assoc();
			$_SESSION['voter'] = $row['voter_id'];
			header('Location: home.php');
			exit();
		} else {
			$_SESSION['error'] = 'Fingerprint not recognized.';
		}
	}
?>
<?php include 'includes/header.php'; ?>
<body class="hold-transition login-page">
<div class="login-box">
  	<div class="login-logo">
  		<b>Fingerprint Voting System</b>
  	</div>
  
  	<div class="login-box-body">
    	<p class="login-box-msg">Sign in to start</p>

		<form action="login.php" method="POST">
            <div class="form-group has-feedback">
                <button type="button" class="btn btn-primary btn-block btn-flat" onclick="startFingerprintScan()">Scan Fingerprint</button>
            </div>
            <input type="hidden" name="fingerprint_data" id="fingerprintData">
        </form>

    	<form action="login.php" method="POST">
      		<div class="form-group has-feedback">
        		<input type="text" class="form-control" name="voter" placeholder="Voter's ID" required>
        		<span class="glyphicon glyphicon-user form-control-feedback"></span>
      		</div>
          <div class="form-group has-feedback">
            <input type="password" class="form-control" name="password" placeholder="Password" required>
            <span class="glyphicon glyphicon-lock form-control-feedback"></span>
          </div>
      		<div class="row">
    			<div class="col-xs-4">
          			<button type="submit" class="btn btn-primary btn-block btn-flat" name="login"><i class="fa fa-sign-in"></i> Sign In</button>
        		</div>
      		</div>
    	</form>
  	</div>
  	<?php
  		if(isset($_SESSION['error'])){
  			echo "
  				<div class='callout callout-danger text-center mt20'>
			  		<p>".$_SESSION['error']."</p> 
			  	</div>
  			";
  			unset($_SESSION['error']);
  		}
  	?>
</div>
<script>
function startFingerprintScan() {
    // Trigger fingerprint scanner, get data, populate 'fingerprintData', submit form
}
</script>
	
<?php include 'includes/scripts.php' ?>
</body>
</html>