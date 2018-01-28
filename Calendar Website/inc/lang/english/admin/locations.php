<?php
$hc_lang_locations = array(

//	Add Location
'TitleAdd'			=>	'Add Location',
'InstructAdd'		=>	'Use the form below to add a location to your Helios Calendar.<br /><br />(<span style="color: #0000FF;">*</span>) = Optional Fields, but required for <b>Map Data Update</b>',

//	Edit Location
'TitleEdit'			=>	'Edit Location',
'InstructEdit'		=>	'Use the form below to edit the location.',

//	Browse Location
'TitleBrowse'		=>	'Manage Locations',
'InstructBrowse'	=>	'The list below contains locations available for your events. If you wish to remove a location(s) and assign it\'s events to another location use the Merge Location tool.<br /><br /><img src="'.AdminRoot.'/img/icons/edit.png" width="16" height="16" alt="" /> = Edit Location<br /><img src="'.AdminRoot.'/img/icons/delete.png" width="16" height="16" alt="" /> = Delete Location',

//	Merge Location
'TitleMerge'		=>	'Merge Locations',
'InstructMerge1'	=>	'Step 1 of 3) Search for the locations you wish to merge. Location serch supports fulltext operators to allow for precise searching of locations to merge.',
'InstructMerge2'	=>	'Step 2 of 3) To merge any of the locations below, and assign their collective events to a single location, select the locations you wish to merge and click "Merge Selected Locations" below.<br /><br /><img src="' . AdminRoot . '/img/icons/edit.png" width="16" height="16" alt="" /> - Edit Location (Opens in New Window)',
'InstructMerge3'	=>	'Step 3 of 3) To merge the locations below select the location you want to merge the others with by selecting the radio button next to that location.<br /><br />The <b>selected location</b> will replace the other locations and their collective events will be assigned to it.',

//	Form Elements
'Filter'			=>	'Search Locations',
'AllLink'			=>	'Clear Search Filter',
'FollowLabel'		=>	'Follow-Up',
'Follow'			=>	'Follow-Up:',
'Follow0'			=>	'Off',
'Follow1'			=>	'On',
'FollowNote'		=>	'Notes:',
'SelectAll'			=>	'Select All',
'DeselectAll'		=>	'Deselect All',
'NameLabel'			=>	'Name',
'StatusLabel'		=>	'Status',
'Events'			=>	'Events',
'Public'			=>	'Public',
'AdminOnly'			=>	'Admin Only',
'NoLoc'				=>	'There are currently no locations available, or no locations meeting that criteria.',
'NoLocLink'			=>	'Click here to search again.',
'Add'				=>	'Add',
'Edit'				=>	'Edit',
'Details'			=>	'Location Details',
'Name'				=>	'Name:',
'Address'			=>	'Address:',
'Address2'			=>	'&nbsp;',
'City'				=>	'City:',
'Postal'			=>	'Zip Code:',
'Country'			=>	'Country:',
'Email'				=>	'Email:',
'Phone'				=>	'Phone:',
'Website'			=>	'Website:',
'Status'			=>	'Status:',
'Status0'			=>	'Admin Only',
'Status1'			=>	'Public',
'Map'				=>	'Map Data:',
'Latitude'			=>	'Latitude:',
'Longitude'			=>	'Longitude:',
'Update'			=>	'Download Map Data',
'GeocodeNotice'		=>	'(Retrieve Geocode w/Google Maps API)',
'Description'		=>	'Profile Description:',
'CountryCode'		=>	'Country Code:',
'PostedTo'			=>	'API Submissions:',
'DistPub'			=>	'API Publishing Options',
'DistPubLinks'		=>	'Location Links:',
'EventbriteView'	=>	'View on <b><span style="color:#F26822;">Eventbrite</span></b>.',
'EventbriteLabelA'	=>	'Add to <b><span style="color:#F26822;">Eventbrite</span></b>.',
'EventbriteLabelU'	=>	'Update at <b><span style="color:#F26822;">Eventbrite</span></b>.',
'EventbriteNotice'	=>	'The following information about this location will be submitted:<ul><li>Name</li><li>Address</li><li>City</li><li>Region ('.$hc_lang_config['RegionTitle'].')</li><li>Postal Code</li><li>Country Code - <i>Select from list below.</i></li></ul>',
'SearchLabel'		=>	'Search by Name and/or Street Address',
'LocName'			=>	'Location Search:',
'Preview'			=>	'Preview These Coordinates',
'LinkMap'			=>	'Open Public Location Map',
'LinkProfile'		=>	'Open Public Location Profile',
'BitlyLabel'		=>	'Get Short URL from <b><span style="color:#EE6123;">bitly</span></b>.',
'BitlyHasLink'		=>	'Short URL from <b><span style="color:#EE6123;">bitly</span></b>.',
'BitlyNotice'		=>	'A bitly shortened URL will be generated for the location. This URL will:<ul><li>Add a QR image to the location details for location sharing.</li></ul>',
'BitlyTools'		=>	'A bitly shortened URL has been generated for the location. The following tools are available:',
'BitlyReport'		=>	'URL Profile (Stats &amp; Tools)',
'BitlyLink'			=>	'URL Link',
'BitlyQRImage'		=>	'URL QR Image',
'BitlyQRLink'		=>	'URL QR Page',
'EBOrganizer'		=>	'Organizer:',
'AddMap'			=>	'Address',
'Contact'			=>	'Contact',
'Image'				=>	'Image URL:',
'ImagePreview'		=>	'Image Preview:',
'ImageOpen'			=>	'Click to open in new window.',

//	Form Buttons
'MergeLoc'			=>	'Merge Selected Locations',
'SaveLocation'		=>	'Save Location',
'MergeAsLoc'		=>	'Merge as Selected Location',
'Search'			=>	'Begin Search',

//	Browse Locations
'Page'				=>	'Page:',
'ResPer'			=>	'Show Per Page:',

//	Validation
'Valid01'			=>	'Location Delete Is Permanent!\nAre you sure you want to delete this location?',
'Valid02'			=>	'Ok = YES Delete Location',
'Valid03'			=>	'Cancel = NO Do Not Delete Location',
'Valid04'			=>	'At least two locations required.\nPlease select more locations and try again.',
'Valid05'			=>	'is Required to Update Map Data',
'Valid06'			=>	'Location Name is Required',
'Valid07'			=>	'Address is Required to Update Map Data',
'Valid08'			=>	'City is Required to Update Map Data',
'Valid09'			=>	'Zip Code is Required to Update Map Data',
'Valid10'			=>	'Geocode Latitude Must Be Numeric',
'Valid11'			=>	'Geocode Longitude Must Be Numeric',
'Valid12'			=>	'Please make the required changes and try again.',
'Valid13'			=>	'This will update Latitude and Longitude data with a new download from Google.\nAre you sure you want to download new map data for this Location?',
'Valid14'			=>	'Ok = YES, Save Location and Download New Data',
'Valid15'			=>	'Cancel = NO, Stop Save and DO NOT Download New Data',
'Valid16'			=>	'You must select a location to merge the others with.\nPlease select a location and try again.',
'Valid17'			=>	'Email Address Format Invalid',
'Valid18'			=>	'Location Image URL Format Invalid',
'Valid19'			=>	'Location name search criteria must be at least 4 (four) characters.',
'Valid20'			=>	'',
'Valid21'			=>	'Country Code Required for Eventbrite Submission',

//	Feedback
'Feed01'			=>	'Location created successfully.',
'Feed02'			=>	'Location updated successfully.',
'Feed03'			=>	'Location deleted successfully.',
'Feed04'			=>	'Locations could not be merged, please try again.',
'Feed05'			=>	'Locations merged successfully.'
);	?>