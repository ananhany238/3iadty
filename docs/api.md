Area	Endpoints	Who
Auth	POST /auth/register, POST /auth/login	Public
Patients	GET /patients, GET /patients/{id}, POST, PUT /{id}, DELETE /{id}	Assistant, Doctor (patients get GET /patients/me)
Visits	GET /patients/{id}/visits, POST /patients/{id}/visits	Assistant, Doctor
Prescriptions	POST /visits/{id}/prescriptions, GET /visits/{id}/prescriptions	Doctor, Assistant
Appointments	GET /appointments, POST /appointments, PUT /appointments/{id}/approve, PUT /appointments/{id}/reject	Patient requests, staff reviews
Audit	GET /audit-logs	Doctor/Admin