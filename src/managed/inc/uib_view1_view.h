
/*******************************************************************************
* This file was generated by UI Builder.
* This file will be auto-generated each and everytime you save your project.
* Do not hand edit this file.
********************************************************************************/
				
#ifndef UIB_VIEW1_VIEW_H_
#define UIB_VIEW1_VIEW_H_


#include "g_inc_uib.h"
#include "uib_views.h"

/**
* view context definitions
*/

typedef struct _uib_view1_view_context {

	/* parent evas_object which was parameter of create function */
	Evas_Object *parent;
	/* root container UI Component of this view */
	Evas_Object *root_container;
	/* view class name */
	const char *view_name;
	/* indicator state of this view */
	int indicator_state;
	/* This is view type. 'true' is user view, otherwise a UI Builder's view. */
	bool is_user_view;
	/* control context to control this view */
	struct _uib_view1_control_context *cc;

	/* UI Components in this view */
	Evas_Object *grid1;
	Evas_Object *circle_object_grid1;
	Evas_Object *topLabel;
	Evas_Object *circle_object_topLabel;
	Evas_Object *l1;
	Evas_Object *circle_object_l1;
	Evas_Object *l2;
	Evas_Object *circle_object_l2;
	Evas_Object *l3;
	Evas_Object *circle_object_l3;
	Evas_Object *l4;
	Evas_Object *circle_object_l4;
	Evas_Object *l5;
	Evas_Object *circle_object_l5;
	Evas_Object *l6;
	Evas_Object *circle_object_l6;
	Evas_Object *bottomLabel;
	Evas_Object *circle_object_bottomLabel;
	Evas_Object *v1;
	Evas_Object *circle_object_v1;
	Evas_Object *v2;
	Evas_Object *circle_object_v2;
	Evas_Object *v3;
	Evas_Object *circle_object_v3;
	Evas_Object *v4;
	Evas_Object *circle_object_v4;
	Evas_Object *v5;
	Evas_Object *circle_object_v5;
	Evas_Object *v6;
	Evas_Object *circle_object_v6;
	Evas_Object *hrv;
	Evas_Object *circle_object_hrv;
	Evas_Object *hrl;
	Evas_Object *circle_object_hrl;
	Evas_Object *exitButton;
	Evas_Object *circle_object_exitButton;
} uib_view1_view_context;



/**
* @brief	Create a new view then return view context of that view.
* 			You can delete view using evas_object_del(vc->evas_object) like other EFL evas objects.
*/
uib_view_context *uib_view_view1_create(Evas_Object *parent, void *create_callback_param);
uib_view_context *uib_view_view1_destroy(Evas_Object *parent, void *create_callback_param);

void uib_view1_config_CIRCLE_360x360_portrait();
#endif /* UIB_VIEW1_VIEW_H_ */
