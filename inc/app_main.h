#ifndef __APP_MAIN_H__
#define __APP_MAIN_H__

#define ENABLE_UIB_DELOG

#include "g_inc_uib.h"
#include "uib_views.h"

#define FILE_FORMAT "running%d.gpx"
#define FILE_PREFIX "running"

/**
 * @brief Forward declaration of model
 */
typedef struct {

} app_data;

/**< H/W Back Key Event */
/**
 * @brief Add (register) a callback function for H/W Back Key Event to a given evas object.
 * @param[in]   pv_param     The void pointer to be passed to this func.
 * @param[in]   p_evas_obj    evas object (naviframe)
 */
void
nf_hw_back_cb(void* param, Evas_Object * evas_obj, void* event_info);

void
win_del_request_cb(void *data, Evas_Object *obj, void *event_info);

Eina_Bool
nf_root_it_pop_cb(void* elm_win, Elm_Object_Item *it);

/**
 * @brief Create application instance
 * @return Application instance on success, otherwise NULL
 */
app_data *uib_app_create();

/**
 * @brief Destroy application instance
 * @param[in]   app     Application instance
 */
void uib_app_destroy(app_data *app);

void clean_exit();

/**
 * @brief Run Tizen application
 * @param[in]   app     Application instance
 * @param[in]   argc    argc paremeter received in main
 * @param[in]   argv    argv parameter received in main
 */
int uib_app_run(app_data *app, int argc, char **argv);

void app_get_resource(const char *edj_file_in, char *edj_path_out, int edj_path_max);

void top_toggle();
void bottom_toggle();
void l1_toggle();
void l2_toggle();
void l3_toggle();
void l4_toggle();
void l5_toggle();
void l6_toggle();

void update_settings();

char* get_directory();

#endif /* __APP_MAIN_H__ */

