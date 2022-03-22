<?php

class TEMPLATE extends CI_Model {

	function __construct() {
		parent::__construct();
	}

	function edit($id, $field_edit) {
		$select = "";
		foreach ($field_edit as $row) {
			$select .= "," . $row;
		}

		$select = substr($select, 1);
		$this->db->select($select);
		$d = $this->db->get_where('TABELLA', array('id' => $id))->row();
		return $d;
	}

	function check_delete($id) {
		$result['success'] = true;
		$result["errorType"] = "danger";
		$result["errorCode"] = "001";
		$result["errorMessage"] = "Impossibile eliminare";
		$result["fieldFocus"] = "numero";

		return $result;
	}

	function delete($id) {
		$this->db->delete('TABELLA', array('id' => $id));
		return;
	}

	function check_update($id) {
		$result['success'] = true;
		$result["errorType"] = "danger";
		$result["errorCode"] = "001";
		$result["errorMessage"] = "Impossibile aggiornare";
		$result["fieldFocus"] = "numero";

		return $result;
	}

	function update($id) {
		session_start();
		$campi = $this->input->post();

		$data = array();
		foreach ($campi as $key => $value) {
			if (substr($value, 2, 1) == "/" && substr($value, 5, 1) == "/" && substr($value, 13, 1) == ":") {
				$value = substr($value, 6, 4) . "-" . substr($value, 3, 2) . "-" . substr($value, 0, 2) . " " . substr($value, 11, 2) . ":" . substr($value, 14, 2);
			}

			$data = array_merge($data, array($key => $value));
		}

		$this->db->where('id', $id);
		$this->db->update('TABELLA', $data);
	}

	function get_paged_list($select = '*', $limit = 10, $offset = 0, $order_column = '', $order_type = 'asc', $search_text = '', $filter_text = '', $idpersonale = 0) {
		$this->db->select($select);
		if ($idpersonale != 0) {
			$this->db->where('idpersonale', $idpersonale);
		}
		$idUser = $_SESSION["id"];
		$this->db->where('iduser', $idUser);
		if (empty($order_column) || empty($order_type)) {
			$this->db->order_by("id", 'desc');
		} else {
			$this->db->order_by(str_replace('-', ',', $order_column), $order_type);
		}

		$this->db->from("tabella a");

		if ($search_text != '') {
			$search_text = urldecode($search_text);

			$where = explode(",", $select);
			$search = explode("#", $search_text);
			for ($j = 0; $j < count($search); $j++) {
				for ($i = 1; $i < count($where); $i++) {
					if (($i + $j) == 1) {
						$this->db->like($where[$i], $search[$j]);
					} else {
						$this->db->or_like($where[$i], $search[$j]);
					}
				}
			}
		}

		$this->db->limit($limit, $offset);

		$ambil = $this->db->get();

		if ($ambil->num_rows() > 0) {
			foreach ($ambil->result() as $data) {
				$hasil[] = $data;
			}
			return $hasil;
		} else {
			return array();
		}
	}

	function count_all($select = '*', $idpersonale = 0, $limit = 10, $offset = 0, $order_column = 'cognome', $order_type = 'asc', $search_text = '') {
		$this->db->select($select);
		if ($idpersonale != 0) {
			$this->db->where('idpersonale', $idpersonale);
		}
		$idUser = $_SESSION["id"];
		$this->db->where('iduser', $idUser);

		$this->db->from("TABELLA a");

		if ($search_text != '') {
			$search_text = urldecode($search_text);

			$where = explode(",", $select);
			$search = explode("#", $search_text);
			for ($j = 0; $j < count($search); $j++) {
				for ($i = 1; $i < count($where); $i++) {
					if (($i + $j) == 1) {
						$this->db->like($where[$i], $search[$j]);
					} else {
						$this->db->or_like($where[$i], $search[$j]);
					}
				}
			}
		}

		$this->db->limit($limit, $offset);

		return $this->db->get()->num_rows();
	}
}
