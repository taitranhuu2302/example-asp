import React, {useState} from 'react';
import {Button, Table} from "reactstrap";
import {useMutation, useQuery} from "react-query";
import {deleteContact, fetchAllContacts} from "../services/ContactService";
import ContactModal from "./ContactModal";
import Swal from 'sweetalert2'

const Home = () => {
    const {data, refetch} = useQuery(["FETCH_ALL_CONTACT"], fetchAllContacts)
    const [openContact, setOpenContact] = useState(false);
    const deleteContactApi = useMutation(deleteContact);
    const [contactUpdate, setContactUpdate] = useState(null);
    const handleDelete = (id) => {
        Swal.fire({
            title: 'Bạn có muốn xoá liên hệ này ?',
            showCancelButton: true,
            confirmButtonText: 'Delete',
        }).then(async (result) => {
            if (result.isConfirmed) {
                await deleteContactApi.mutateAsync(id);
                await refetch();
                await Swal.fire('Xoá thành công!', '', 'success')
            } 
        })
    }
    
    return <>
        <h2 className={'display-6'}><strong>Contact</strong></h2>
        <div className={'d-flex justify-content-end'}>
            <Button color={'success'} onClick={() => setOpenContact(true)}>Thêm liên hệ</Button>
        </div>
        <Table>
            <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Họ và tên</th>
                <th scope="col">Email</th>
                <th scope="col">Quốc gia</th>
                <th scope="col">Số điện thoại</th>
                <th colSpan={2} scope="col">Hành động</th>
            </tr>
            </thead>
            <tbody>
            {
                data && data.map((item, index) => {
                    return (
                        <tr key={item.id}>
                            <th scope="row">{index + 1}</th>
                            <td>{item.fullName}</td>
                            <td>{item.email}</td>
                            <td>{item.country}</td>
                            <td>{item.numberPhone}</td>
                            <td>
                                <Button color="danger" onClick={() => handleDelete(item.id)}>
                                    Xoá
                                </Button>
                            </td>
                            <td>
                                <Button color="primary" onClick={() => {
                                    setOpenContact(true)
                                    setContactUpdate(item)
                                }}>
                                    Sửa
                                </Button>
                            </td>
                        </tr>
                    )
                })
            }
            </tbody>
        </Table>
        <ContactModal open={openContact} contact={contactUpdate} onToggle={() => {
            setOpenContact(e => !e)
            setContactUpdate(null)
        }} refetch={refetch}/>
    </>
}

export default Home;