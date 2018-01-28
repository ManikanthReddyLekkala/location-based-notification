<?php
/**
 * @package Helios Calendar
 * @license GNU General Public License version 2 or later; see LICENSE
 */
	if(!defined('isHC')){exit(-1);}
	
	// Development -1, Production 0
	error_reporting(0);
	
	/** MySQL Hostname. Typically localhost, however, it may vary for your environment.*/
	define("DB_HOST", "localhost");
	/** MySQL Database Name*/
	define("DB_NAME", "cal_mlekkala");
	/** MySQL Server Username.*/
	define("DB_USER", "mlekkala");
	/** MySQL Server Password. */
	define("DB_PASS", "mlekkala@007");
	/** MySQL Datatable Prefix. Should only be edited prior to first setup. */
	define("HC_TblPrefix", "hc_");
	
	/** APC Cache Entry Prefix. */
	define("HC_APCPrefix", "hc_");
		
	/** Calendar URL. */
	define("CalRoot", "http://csclab.murraystate.edu/mlekkala");
	/** Admin Console URL */
	define("AdminRoot", "http://csclab.murraystate.edu/mlekkala/admin");
	/** Calendar Name */
	define("CalName", "Our Calendar");
	
	/**
	 * A random string used to create cookies named uniquely for your calendar.
	 * A length of at least 40 random characters is recommended. Generator available at link.
	 */
	define("HC_Rando", "qsdfghjklpoiuytrewzxcvbnmloikjhgfdrtyuiop");
	
	/**
	 * Access code to perform installation and upgrades.
	 */
	define("HC_Install", "123456");
		
	/**
	 * The following configuration options are not required for all installs. For details please visit the setup documentation.
	 */
	
	/** Enable Named Setting Variable Cache */
	//define("HC_Named", true);
	
	/** Specify Server Timezone */
	//ini_set('date.timezone','');
	
	/** Manually defined session save path. */
	//session_save_path("");
?>