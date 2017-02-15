
/*******************************************************************************
* This file was generated by UI Builder.
* This file will be auto-generated each and everytime you save your project.
* Do not hand edit this file.
********************************************************************************/
		#include "g_inc_uib.h"
#include "uib_views.h"
#include "uib_views_inc.h"
#include "uib_app_manager.h"

/* event handler declarations */
void view1_topLabel_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_label_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_label_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_label_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_bottomLabel_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_label_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_label_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_label_onclicked(uib_view1_view_context*, Evas_Object*, void*);
void view1_exitButton_onclicked(uib_view1_view_context*, Evas_Object*, void*);

uib_view_context* uib_view_view1_create(Evas_Object* parent, void* create_callback_param) {
	uib_view1_view_context* vc = calloc(1, sizeof(uib_view1_view_context));
	vc->parent = parent;
	vc->view_name = "view1";
	vc->indicator_state = ELM_WIN_INDICATOR_SHOW;
	vc->is_user_view = false;
	uib_app_manager_get_instance()->add_view_context((uib_view_context*)vc);
	if (!vc->grid1) {
		vc->grid1= elm_grid_add(parent);
		vc->root_container = vc->grid1;
	}
	uib_views_get_instance()->set_targeted_view((uib_view_context*)vc);

	//bind event handler
	evas_object_smart_callback_add(vc->topLabel, "clicked", (Evas_Smart_Cb)view1_topLabel_onclicked, vc);
	evas_object_smart_callback_add(vc->l1, "clicked", (Evas_Smart_Cb)view1_label_onclicked, vc);
	evas_object_smart_callback_add(vc->l2, "clicked", (Evas_Smart_Cb)view1_label_onclicked, vc);
	evas_object_smart_callback_add(vc->l3, "clicked", (Evas_Smart_Cb)view1_label_onclicked, vc);
	evas_object_smart_callback_add(vc->bottomLabel, "clicked", (Evas_Smart_Cb)view1_bottomLabel_onclicked, vc);
	evas_object_smart_callback_add(vc->v1, "clicked", (Evas_Smart_Cb)view1_label_onclicked, vc);
	evas_object_smart_callback_add(vc->v2, "clicked", (Evas_Smart_Cb)view1_label_onclicked, vc);
	evas_object_smart_callback_add(vc->v3, "clicked", (Evas_Smart_Cb)view1_label_onclicked, vc);
	evas_object_smart_callback_add(vc->exitButton, "clicked", (Evas_Smart_Cb)view1_exitButton_onclicked, vc);


	evas_object_data_set(vc->root_container, KEY_VIEW_CONTEXT, vc);
	uib_views_create_callback(vc, evas_object_evas_get(vc->root_container), vc->root_container, create_callback_param);
	evas_object_event_callback_add(vc->root_container, EVAS_CALLBACK_DEL, (Evas_Object_Event_Cb)uib_views_destroy_callback, vc);

	return (uib_view_context*)vc;
}
void uib_view1_config_CIRCLE_360x360_portrait() {
	uib_app_manager_st* uib_app_manager = uib_app_manager_get_instance();
	uib_view1_view_context* vc = (uib_view1_view_context*)uib_app_manager->find_view_context("view1");
	if(!vc) {
		return;
	}
	if(vc->grid1) {
		elm_grid_clear(vc->grid1, EINA_FALSE);
		evas_object_size_hint_align_set(vc->grid1, -1.0, -1.0);		evas_object_size_hint_weight_set(vc->grid1, 1.0, 1.0);		elm_grid_size_set(vc->grid1, 1000, 1000);
		if (!vc->topLabel) {
			vc->topLabel = elm_label_add(vc->grid1);
		}
		if(vc->topLabel) {
			evas_object_size_hint_align_set(vc->topLabel, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->topLabel, 1.0, 1.0);			elm_label_line_wrap_set(vc->topLabel, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->topLabel,0);
			elm_label_ellipsis_set(vc->topLabel, EINA_FALSE);
			evas_object_show(vc->topLabel);
		}
		if (!vc->l1) {
			vc->l1 = elm_label_add(vc->grid1);
		}
		if(vc->l1) {
			evas_object_size_hint_align_set(vc->l1, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->l1, 1.0, 1.0);			elm_label_line_wrap_set(vc->l1, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->l1,0);
			elm_label_ellipsis_set(vc->l1, EINA_FALSE);
			evas_object_show(vc->l1);
		}
		if (!vc->l2) {
			vc->l2 = elm_label_add(vc->grid1);
		}
		if(vc->l2) {
			evas_object_size_hint_align_set(vc->l2, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->l2, 1.0, 1.0);			elm_label_line_wrap_set(vc->l2, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->l2,0);
			elm_label_ellipsis_set(vc->l2, EINA_FALSE);
			evas_object_show(vc->l2);
		}
		if (!vc->l3) {
			vc->l3 = elm_label_add(vc->grid1);
		}
		if(vc->l3) {
			evas_object_size_hint_align_set(vc->l3, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->l3, 1.0, 1.0);			elm_label_line_wrap_set(vc->l3, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->l3,0);
			elm_label_ellipsis_set(vc->l3, EINA_FALSE);
			evas_object_show(vc->l3);
		}
		if (!vc->l4) {
			vc->l4 = elm_label_add(vc->grid1);
		}
		if(vc->l4) {
			evas_object_size_hint_align_set(vc->l4, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->l4, 1.0, 1.0);			elm_label_line_wrap_set(vc->l4, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->l4,0);
			elm_label_ellipsis_set(vc->l4, EINA_FALSE);
			evas_object_show(vc->l4);
		}
		if (!vc->l5) {
			vc->l5 = elm_label_add(vc->grid1);
		}
		if(vc->l5) {
			evas_object_size_hint_align_set(vc->l5, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->l5, 1.0, 1.0);			elm_label_line_wrap_set(vc->l5, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->l5,0);
			elm_label_ellipsis_set(vc->l5, EINA_FALSE);
			evas_object_show(vc->l5);
		}
		if (!vc->l6) {
			vc->l6 = elm_label_add(vc->grid1);
		}
		if(vc->l6) {
			evas_object_size_hint_align_set(vc->l6, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->l6, 1.0, 1.0);			elm_label_line_wrap_set(vc->l6, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->l6,0);
			elm_label_ellipsis_set(vc->l6, EINA_FALSE);
			evas_object_show(vc->l6);
		}
		if (!vc->bottomLabel) {
			vc->bottomLabel = elm_label_add(vc->grid1);
		}
		if(vc->bottomLabel) {
			evas_object_size_hint_align_set(vc->bottomLabel, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->bottomLabel, 1.0, 1.0);			elm_label_line_wrap_set(vc->bottomLabel, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->bottomLabel,0);
			elm_label_ellipsis_set(vc->bottomLabel, EINA_FALSE);
			evas_object_show(vc->bottomLabel);
		}
		if (!vc->v1) {
			vc->v1 = elm_label_add(vc->grid1);
		}
		if(vc->v1) {
			evas_object_size_hint_align_set(vc->v1, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->v1, 1.0, 1.0);			elm_label_line_wrap_set(vc->v1, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->v1,0);
			elm_label_ellipsis_set(vc->v1, EINA_FALSE);
			evas_object_show(vc->v1);
		}
		if (!vc->v2) {
			vc->v2 = elm_label_add(vc->grid1);
		}
		if(vc->v2) {
			evas_object_size_hint_align_set(vc->v2, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->v2, 1.0, 1.0);			elm_label_line_wrap_set(vc->v2, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->v2,0);
			elm_label_ellipsis_set(vc->v2, EINA_FALSE);
			evas_object_show(vc->v2);
		}
		if (!vc->v3) {
			vc->v3 = elm_label_add(vc->grid1);
		}
		if(vc->v3) {
			evas_object_size_hint_align_set(vc->v3, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->v3, 1.0, 1.0);			elm_label_line_wrap_set(vc->v3, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->v3,0);
			elm_label_ellipsis_set(vc->v3, EINA_FALSE);
			evas_object_show(vc->v3);
		}
		if (!vc->v4) {
			vc->v4 = elm_label_add(vc->grid1);
		}
		if(vc->v4) {
			evas_object_size_hint_align_set(vc->v4, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->v4, 1.0, 1.0);			elm_label_line_wrap_set(vc->v4, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->v4,0);
			elm_label_ellipsis_set(vc->v4, EINA_FALSE);
			evas_object_show(vc->v4);
		}
		if (!vc->v5) {
			vc->v5 = elm_label_add(vc->grid1);
		}
		if(vc->v5) {
			evas_object_size_hint_align_set(vc->v5, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->v5, 1.0, 1.0);			elm_label_line_wrap_set(vc->v5, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->v5,0);
			elm_label_ellipsis_set(vc->v5, EINA_FALSE);
			evas_object_show(vc->v5);
		}
		if (!vc->v6) {
			vc->v6 = elm_label_add(vc->grid1);
		}
		if(vc->v6) {
			evas_object_size_hint_align_set(vc->v6, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->v6, 1.0, 1.0);			elm_label_line_wrap_set(vc->v6, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->v6,0);
			elm_label_ellipsis_set(vc->v6, EINA_FALSE);
			evas_object_show(vc->v6);
		}
		if (!vc->hrv) {
			vc->hrv = elm_label_add(vc->grid1);
		}
		if(vc->hrv) {
			evas_object_size_hint_align_set(vc->hrv, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->hrv, 1.0, 1.0);			elm_label_line_wrap_set(vc->hrv, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->hrv,0);
			elm_label_ellipsis_set(vc->hrv, EINA_FALSE);
			evas_object_show(vc->hrv);
		}
		if (!vc->hrl) {
			vc->hrl = elm_label_add(vc->grid1);
		}
		if(vc->hrl) {
			evas_object_size_hint_align_set(vc->hrl, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->hrl, 1.0, 1.0);			elm_object_text_set(vc->hrl,_UIB_LOCALE("HR"));
			elm_label_line_wrap_set(vc->hrl, (Elm_Wrap_Type)ELM_WRAP_NONE);
			elm_label_wrap_width_set(vc->hrl,0);
			elm_label_ellipsis_set(vc->hrl, EINA_FALSE);
			evas_object_show(vc->hrl);
		}
		if (!vc->exitButton) {
			vc->exitButton = elm_button_add(vc->grid1);
		}
		if (vc->exitButton) {
			evas_object_size_hint_align_set(vc->exitButton, -1.0, -1.0);			evas_object_size_hint_weight_set(vc->exitButton, 1.0, 1.0);			elm_object_text_set(vc->exitButton,_UIB_LOCALE("X"));
			elm_object_style_set(vc->exitButton,"default");
			evas_object_show(vc->exitButton);
		}
		elm_grid_pack(vc->grid1, vc->topLabel, 367, 34, 236, 103);		elm_grid_pack(vc->grid1, vc->l1, 169, 133, 272, 112);		elm_grid_pack(vc->grid1, vc->l2, 167, 264, 272, 114);		elm_grid_pack(vc->grid1, vc->l3, 187, 398, 252, 114);		elm_grid_pack(vc->grid1, vc->l4, 187, 508, 252, 114);		elm_grid_pack(vc->grid1, vc->l5, 167, 639, 272, 114);		elm_grid_pack(vc->grid1, vc->l6, 167, 750, 272, 114);		elm_grid_pack(vc->grid1, vc->bottomLabel, 367, 866, 236, 103);		elm_grid_pack(vc->grid1, vc->v1, 435, 156, 397, 111);		elm_grid_pack(vc->grid1, vc->v2, 433, 264, 397, 111);		elm_grid_pack(vc->grid1, vc->v3, 431, 397, 397, 111);		elm_grid_pack(vc->grid1, vc->v4, 431, 506, 397, 111);		elm_grid_pack(vc->grid1, vc->v5, 431, 639, 397, 111);		elm_grid_pack(vc->grid1, vc->v6, 431, 750, 397, 111);		elm_grid_pack(vc->grid1, vc->hrv, 20, 506, 166, 111);		elm_grid_pack(vc->grid1, vc->hrl, 20, 397, 166, 111);		elm_grid_pack(vc->grid1, vc->exitButton, 864, 372, 150, 250);		evas_object_show(vc->grid1);
	}
}

