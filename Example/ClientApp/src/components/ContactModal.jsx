import React, {useEffect, useMemo, useState} from 'react';
import {Button, Form, FormGroup, Label, Modal, ModalBody, ModalHeader} from 'reactstrap';
import {useForm} from "react-hook-form";
import * as yup from 'yup';
import "yup-phone";
import {yupResolver} from '@hookform/resolvers/yup';
import {CountryCode} from "../constants/CountryCode";
import {useMutation} from "react-query";
import {createContact, updateContact} from "../services/ContactService";
import Swal from "sweetalert2";

const schema = yup.object().shape({
  fullName: yup.string().required(),
  email: yup.string().email().required(),
  country: yup.string().required(),
})

const ContactModal = ({open, onToggle, contact, refetch}) => {
  const {register, handleSubmit, formState: {errors}, reset, setValue} = useForm({
    resolver: yupResolver(schema)
  });
  const [errorPhone, setErrorPhone] = useState("");
  const createContactApi = useMutation(createContact)
  const updateContactApi = useMutation(updateContact)


  useEffect(() => {
    if (contact) {
      setValue("fullName", contact.fullName)
      setValue("email", contact.email)
      setValue("country", CountryCode.filter(item => item.name === contact?.country)[0]?.code)
      setValue("phoneNumber", contact.numberPhone)
    } else {
      reset({
        fullName: '',
        email: '',
        country: '',
        phoneNumber: ''
      })
    }
  }, [contact])

  const onSubmit = async (data) => {
    const phoneSchema = await yup.string()
      .phone(data.country)
      .required().isValid(data.phoneNumber);
    if (!phoneSchema) {
      setErrorPhone("Phone number not valid");
      return;
    }
    const request = {
      ...data,
      country: CountryCode.filter(item => item.code === data.country)[0].name,
      numberPhone: data.phoneNumber
    }
    if (!contact) {
      await createContactApi.mutateAsync(request);
      await refetch();
      await Swal.fire('Tạo thành công!', '', 'success')
    } else {
      Swal.fire({
        title: 'Bạn có chắc chắn là muốn thay đổi ?',
        showCancelButton: true,
        confirmButtonText: 'OK',
      }).then(async (result) => {
        if (result.isConfirmed) {
          await updateContactApi.mutateAsync({id: contact.id, data: request});
          await refetch();
          await Swal.fire('Cập nhật thành công!', '', 'success')
        }
      })
    }

    setErrorPhone("")
    reset({
      fullName: '',
      email: '',
      country: '',
      phoneNumber: ''
    })
    onToggle();
  }

  return <>
    <Modal isOpen={open} toggle={onToggle}>
      <ModalHeader toggle={onToggle}>{contact ? "Sửa liên hệ" : "Thêm liên hệ"}</ModalHeader>
      <ModalBody>
        <Form onSubmit={handleSubmit(onSubmit)}>
          <FormGroup>
            <Label for="examplePassword">
              Full Name
            </Label>
            <input className={'form-control'} {...register('fullName')}/>

            {
              errors.fullName && (<div className="text-danger">
                {errors.fullName.message}
              </div>)
            }
          </FormGroup>
          <FormGroup>
            <Label for="examplePassword">
              Email
            </Label>
            <input className={'form-control'} {...register('email')}/>
            {
              errors.email && (<div className="text-danger">
                {errors.email.message}
              </div>)
            }
          </FormGroup>
          <FormGroup>
            <Label for="examplePassword">
              Country
            </Label>
            <select className={'form-control'} {...register('country')}>
              {
                CountryCode.map((item, index) => {
                  return <option key={index} value={item.code}>{item.name}</option>
                })
              }
            </select>
            {
              errors.country && (<div className="text-danger">
                {errors.country.message}
              </div>)
            }
          </FormGroup>
          <FormGroup>
            <Label for="examplePassword">
              Phone
            </Label>
            <input className={'form-control'} {...register('phoneNumber')}/>
            {
              errorPhone && (<div className="text-danger">
                {errorPhone}
              </div>)
            }
          </FormGroup>
          {/*<InputCt label={'Phone'} {...register('phoneNumber')} error={errors.phone}/>*/}
          <div className={'d-flex justify-content-end gap-3'}>
            <Button type={'submit'} color="primary">
              Lưu
            </Button>{' '}
            <Button color="secondary" onClick={onToggle}>
              Huỷ bỏ
            </Button>
          </div>
        </Form>
      </ModalBody>
    </Modal>
  </>
}

export default ContactModal;