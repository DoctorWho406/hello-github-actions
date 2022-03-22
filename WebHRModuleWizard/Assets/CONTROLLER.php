<?php if (!defined('BASEPATH')) exit('No direct script access allowed');

require_once APPPATH . 'core/MY_Amm_Controller.php';
//or
require_once APPPATH . 'core/MY_Controller.php';

// class Mod_amm_template extends MY_Controller {
//or
class Mod_amm_template extends MY_Amm_Controller {

	public $idmodule = 7;
	public $descrizione = "DESCRIZIONE";
	public $modulecode = "mod_[amm]_template";
	public  $model = "TEMPLATE";

	public $select = "SELECT";

	public $view = array(
		array(
			'title' => 'ID',
			'field' => 'ID',
			'order' => 'ID',
			'type' => '',
			'column' => 0,
			'showed' => 0
		),
		array(
			'title' => 'TITLE',
			'field' => 'FIELD',
			'order' => 'FIELD',
			'type' => 'TYPE',
			'column' => 6,
			'showed' => 1
		),
	);


	public $filters = array(
		array(
			'title' => 'TITLE',
			'field' => 'FIELD',
			'type' => 'TYPE',
			'size' => 6
		)
	);

	public $add = array(
		array(
			'title' => 'TITLE',
			'field' => 'FIELD',
			'type' => 'TYPE',
			'size' => 6,
			'check' => '[obbligatorio]'
		),
	);

	public $edit = array(
		array(
			'title' => 'TITLE',
			'field' => 'FIELD',
			'type' => 'TYPE',
			'size' => 6,
			'check' => '[obbligatorio]'
		),
	);

	public $def_order = 'FIELD';


	public $gestione = array("add", "view", "mod", "del");
	public $funzioni = 1;
	public $operazioni = array();

	public function __construct() {
		parent::__construct();
		parent::$default_order = $this->def_order;
	}

	function delete($filters_text, $id) {
		$this->load->model($this->model, "m");

		$result = array();
		if (method_exists($this->m, 'check_delete')) {
			$result = $this->m->check_delete($id);
		} else {
			$result['status'] = true;
		}
		if ($result['status']) {
			$this->m->delete($id);
			redirect($this->modulecode . '/index/' . $filters_text);
		} else {
			header("HTTP/1.0 404 Not Found");
			return $result;
		}
	}

	function save($filters_text, $idref = 0) {
		$this->load->model($this->model, "m");

		$result = array();
		if (method_exists($this->m, 'check_save')) {
			$result = $this->m->check_save();
		} else {
			$result['status'] = true;
		}
		if ($result['status']) {
			$this->m->add();
			redirect($this->modulecode . '/index/' . $filters_text);
		} else {
			header("HTTP/1.0 404 Not Found");
			return $result;
		}
	}

	function update($filters_text, $id) {
		$this->load->model($this->model, "m");

		$result = array();
		if (method_exists($this->m, 'check_update')) {
			$result = $this->m->check_update($id);
		} else {
			$result['status'] = true;
		}
		if ($result['status']) {
			$this->m->update($id);
			redirect($this->modulecode . '/index/' . $filters_text);
		} else {
			header("HTTP/1.0 404 Not Found");
			echo $result;
		}
	}
}
